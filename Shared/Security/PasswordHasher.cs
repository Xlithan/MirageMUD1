using System.Security.Cryptography;
using System.Text;

namespace Shared.Security
{
    // PBKDF2 (HMACSHA256). Format: pbkdf2|v=1|{iterations}|{saltBase64}|{hashBase64}
    public static class PasswordHasher
    {
        private const int Iterations = 120_000;
        private const int SaltBytes = 16;
        private const int KeyBytes = 32;

        public static string Hash(string password)
        {
            using var rng = RandomNumberGenerator.Create();
            var salt = new byte[SaltBytes];
            rng.GetBytes(salt);

            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            var key = pbkdf2.GetBytes(KeyBytes);

            return $"pbkdf2|v=1|{Iterations}|{Convert.ToBase64String(salt)}|{Convert.ToBase64String(key)}";
        }

        public static bool Verify(string password, string encodedHash)
        {
            try
            {
                var parts = encodedHash.Split('|');
                if (parts.Length != 5 || parts[0] != "pbkdf2") return false;

                var iterations = int.Parse(parts[2]);
                var salt = Convert.FromBase64String(parts[3]);
                var expected = Convert.FromBase64String(parts[4]);

                using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
                var actual = pbkdf2.GetBytes(expected.Length);
                return CryptographicOperations.FixedTimeEquals(actual, expected);
            }
            catch
            {
                return false;
            }
        }
    }
}