
using System;
using System.Security.Cryptography;

namespace QuanLyNhaHang.Service
{
    internal class PasswordHelper
    {
        private const int Iterations = 600000;

        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                32
            );

            return "PBKDF2-SHA256$" + Iterations + "$"
                + Convert.ToBase64String(salt) + "$"
                + Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(
            string password, string storedHash)
        {
            try
            {
                string[] parts = storedHash.Split('$');

                if (parts.Length != 4 ||
                    parts[0] != "PBKDF2-SHA256")
                    return false;

                int iterations = int.Parse(parts[1]);

                if (iterations != Iterations)
                    return false;

                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expectedHash = Convert.FromBase64String(parts[3]);

                if (salt.Length != 16 || expectedHash.Length != 32)
                    return false;

                byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    32
                );

                return CryptographicOperations.FixedTimeEquals(
                    actualHash, expectedHash
                );
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
    }
}
