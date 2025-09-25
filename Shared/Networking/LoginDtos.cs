using System.Collections.Generic;
using Shared.Models;   // <-- important

namespace Shared.Networking
{
    public sealed class LoginRequestDto
    {
        public string UsernameOrEmail { get; init; } = "";
        public string Password { get; init; } = "";
        public string ClientVersion { get; init; } = "dev";
    }

    public sealed class LoginResponseDto
    {
        public bool Success { get; init; }
        public string? Message { get; init; }
        public string? AccountId { get; init; }
        public List<CharacterSummary>? Characters { get; init; } // <-- from Shared.Models
    }
}