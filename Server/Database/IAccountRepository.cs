using Shared.Models;

namespace Server.Database
{
    public interface IAccountRepository
    {
        Account? GetByUsernameOrEmail(string usernameOrEmail);
        List<CharacterSummary> GetCharactersForAccount(string accountId);
        Account CreateAccount(string email, string username, string passwordHash, bool emailVerified = true);

        bool CharacterBelongsToAccount(string accountId, string characterId);
        bool DeleteCharacter(string accountId, string characterId);
    }
}