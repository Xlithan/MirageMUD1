using Shared.Models;

namespace Server.Database
{
    public interface IAccountRepository
    {
        Account? GetByUsernameOrEmail(string usernameOrEmail);
        List<CharacterSummary> GetCharactersForAccount(string accountId);

        Account? CreateAccount(string username, string email, string passwordHash);
        bool IsAccountNameAvailable(string username);

        bool CharacterBelongsToAccount(string accountId, string characterId);
        bool DeleteCharacter(string accountId, string characterId);
    }
}