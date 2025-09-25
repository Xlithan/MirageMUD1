using System.Text.Json;
using Shared.Models;

namespace Server.Database
{
    public sealed class JsonAccountRepository : IAccountRepository
    {
        private readonly string _accountsPath;
        private readonly string _charactersPath;
        private readonly object _sync = new();

        private sealed record AccountRow(string Id, string Email, string Username, string PasswordHash, bool EmailVerified, DateTime CreatedUtc);
        private sealed record CharacterRow(string Id, string AccountId, string Name, string Class, int Level);

        public JsonAccountRepository(string dataDir)
        {
            Directory.CreateDirectory(dataDir);
            _accountsPath = Path.Combine(dataDir, "accounts.json");
            _charactersPath = Path.Combine(dataDir, "characters.json");
            if (!File.Exists(_accountsPath)) File.WriteAllText(_accountsPath, "[]");
            if (!File.Exists(_charactersPath)) File.WriteAllText(_charactersPath, "[]");
        }

        public Account? GetByUsernameOrEmail(string usernameOrEmail)
        {
            var list = LoadAccounts();
            var found = list.FirstOrDefault(a =>
                a.Username.Equals(usernameOrEmail, StringComparison.OrdinalIgnoreCase) ||
                a.Email.Equals(usernameOrEmail, StringComparison.OrdinalIgnoreCase));

            return found is null ? null : new Account
            {
                Id = found.Id,
                Email = found.Email,
                Username = found.Username,
                PasswordHash = found.PasswordHash,
                EmailVerified = found.EmailVerified,
                CreatedUtc = found.CreatedUtc
            };
        }

        public List<CharacterSummary> GetCharactersForAccount(string accountId)
        {
            var chars = LoadCharacters().Where(c => c.AccountId == accountId);
            return chars.Select(c => new CharacterSummary
            {
                Id = c.Id,
                Name = c.Name,
                Class = c.Class,
                Level = c.Level
            }).ToList();
        }

        public Account CreateAccount(string email, string username, string passwordHash, bool emailVerified = true)
        {
            var row = new AccountRow(Guid.NewGuid().ToString("N"), email, username, passwordHash, emailVerified, DateTime.UtcNow);
            lock (_sync)
            {
                var list = LoadAccounts();
                list.Add(row);
                SaveAccounts(list);
            }

            return new Account
            {
                Id = row.Id,
                Email = row.Email,
                Username = row.Username,
                PasswordHash = row.PasswordHash,
                EmailVerified = row.EmailVerified,
                CreatedUtc = row.CreatedUtc
            };
        }

        private List<AccountRow> LoadAccounts()
        {
            lock (_sync)
            {
                var json = File.ReadAllText(_accountsPath);
                return JsonSerializer.Deserialize<List<AccountRow>>(json) ?? new();
            }
        }

        private void SaveAccounts(List<AccountRow> rows)
        {
            lock (_sync)
            {
                var json = JsonSerializer.Serialize(rows, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_accountsPath, json);
            }
        }

        private List<CharacterRow> LoadCharacters()
        {
            lock (_sync)
            {
                var json = File.ReadAllText(_charactersPath);
                return JsonSerializer.Deserialize<List<CharacterRow>>(json) ?? new();
            }
        }
        public bool CharacterBelongsToAccount(string accountId, string characterId)
        {
            return LoadCharacters().Any(c => c.AccountId == accountId && c.Id == characterId);
        }

        public bool DeleteCharacter(string accountId, string characterId)
        {
            lock (_sync)
            {
                var list = LoadCharacters();
                var idx = list.FindIndex(c => c.Id == characterId && c.AccountId == accountId);
                if (idx < 0) return false;
                list.RemoveAt(idx);
                var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_charactersPath, json);
                return true;
            }
        }
    }
}