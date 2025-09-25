using Server.Database;
using Shared.Models;
using Shared.Networking;
using Shared.Security;

namespace Server.Game
{
    public sealed class ServerGameLogic
    {
        private readonly IAccountRepository _accounts;
        public List<CharacterSummary> GetCharacters(string accountId)
            => _accounts.GetCharactersForAccount(accountId);

        public bool CharacterBelongsTo(string accountId, string characterId)
            => _accounts.CharacterBelongsToAccount(accountId, characterId);

        public bool DeleteCharacter(string accountId, string characterId)
            => _accounts.DeleteCharacter(accountId, characterId);

        public ServerGameLogic(IAccountRepository accounts)
        {
            _accounts = accounts;
        }

        public LoginResponseDto HandleLogin(LoginRequestDto req)
        {
            var account = _accounts.GetByUsernameOrEmail(req.UsernameOrEmail);
            if (account is null)
            {
                return new LoginResponseDto
                {
                    Success = false,
                    Message = "Account not found."
                };
            }

            if (!PasswordHasher.Verify(req.Password, account.PasswordHash))
            {
                return new LoginResponseDto
                {
                    Success = false,
                    Message = "Invalid credentials."
                };
            }

            // (Optional) require email verification
            // if (!account.EmailVerified) { ... }

            var chars = _accounts.GetCharactersForAccount(account.Id);

            return new LoginResponseDto
            {
                Success = true,
                Message = "OK",
                AccountId = account.Id,
                Characters = chars
            };
        }
    }
}