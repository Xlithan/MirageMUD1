using System.Collections.Concurrent;

namespace Server.Networking
{
    public partial class ServerTcp
    {
        // Using the existing _clients dictionary from the core partial.

        public void SetAccount(int clientId, string accountId)
        {
            if (_clients.TryGetValue(clientId, out var c))
                c.AccountId = accountId;
        }

        public bool TryGetAccount(int clientId, out string? accountId)
        {
            accountId = null;
            if (_clients.TryGetValue(clientId, out var c))
                accountId = c.AccountId;
            return accountId != null;
        }

        public void SetCharacter(int clientId, string characterId)
        {
            if (_clients.TryGetValue(clientId, out var c))
                c.CharacterId = characterId;
        }

        public bool TryGetCharacter(int clientId, out string? characterId)
        {
            characterId = null;
            if (_clients.TryGetValue(clientId, out var c))
                characterId = c.CharacterId;
            return characterId != null;
        }
    }
}