using System;
using System.Security.Cryptography;
using System.Text;

namespace HrApp.Utils
{
    public static class PasswordHasher
    {
        public static string GenerateSalt(int length = 16)
        {
            var saltBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = password + salt;
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string inputPassword, string storedHash, string storedSalt)
        {
            var inputHash = HashPassword(inputPassword, storedSalt);
            return inputHash == storedHash;
        }
    }
}
