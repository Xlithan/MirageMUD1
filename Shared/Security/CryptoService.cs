using System;
using System.Security.Cryptography;

namespace MirageMUD.Shared.Security
{
    public static class CryptoService
    {
        // AES-GCM with 12-byte nonce and 16-byte tag (NIST recommended sizes)
        private const int KeySizeBytes = 32;   // 256-bit
        private const int NonceSize = 12;
        private const int TagSize = 16;

        public static byte[] GenerateRandomKey(int sizeBytes = KeySizeBytes)
        {
            byte[] key = new byte[sizeBytes];
            RandomNumberGenerator.Fill(key);
            return key;
        }

        public static string GenerateKeyBase64(int sizeBytes = KeySizeBytes) =>
            Convert.ToBase64String(GenerateRandomKey(sizeBytes));

        /// <summary>
        /// Encrypts plaintext and returns a single payload of: [12b nonce][ciphertext][16b tag]
        /// </summary>
        public static byte[] Encrypt(byte[] key, ReadOnlySpan<byte> plaintext, ReadOnlySpan<byte> aad = default)
        {
            if (key == null || key.Length != KeySizeBytes)
                throw new ArgumentException("Key must be 32 bytes (256-bit).", nameof(key));

            byte[] nonce = new byte[NonceSize];
            RandomNumberGenerator.Fill(nonce);

            byte[] ciphertext = new byte[plaintext.Length];
            byte[] tag = new byte[TagSize];

            using var aes = new AesGcm(key);
            aes.Encrypt(nonce, plaintext, ciphertext, tag, aad);

            // Compose payload: nonce + ciphertext + tag
            byte[] output = new byte[NonceSize + ciphertext.Length + TagSize];
            Buffer.BlockCopy(nonce, 0, output, 0, NonceSize);
            Buffer.BlockCopy(ciphertext, 0, output, NonceSize, ciphertext.Length);
            Buffer.BlockCopy(tag, 0, output, NonceSize + ciphertext.Length, TagSize);
            return output;
        }

        /// <summary>
        /// Decrypts payload created by Encrypt(). Input must be [nonce][ciphertext][tag].
        /// </summary>
        public static byte[] Decrypt(byte[] key, ReadOnlySpan<byte> payload, ReadOnlySpan<byte> aad = default)
        {
            if (key == null || key.Length != KeySizeBytes)
                throw new ArgumentException("Key must be 32 bytes (256-bit).", nameof(key));
            if (payload.Length < NonceSize + TagSize)
                throw new ArgumentException("Invalid payload.", nameof(payload));

            var nonce = payload[..NonceSize].ToArray();
            var tag = payload[^TagSize..].ToArray();
            var cipher = payload[NonceSize..^TagSize];

            byte[] plaintext = new byte[cipher.Length];

            using var aes = new AesGcm(key);
            aes.Decrypt(nonce, cipher, tag, plaintext, aad);
            return plaintext;
        }

        public static byte[] KeyFromBase64(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64)) throw new ArgumentException("Key is empty.");
            var key = Convert.FromBase64String(base64);
            if (key.Length != KeySizeBytes) throw new ArgumentException("Key must decode to 32 bytes.");
            return key;
        }
    }
}