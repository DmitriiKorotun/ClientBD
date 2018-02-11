using System;
using System.Text;
using System.Security.Cryptography;
using BCrypt.Net;

namespace ClientBD.Encryption
{
    class Encryption
    {
        //public class AES256
        //{
        //    AesManaged AESHandler;

        //    public string Encrypt(string value, byte[] key)
        //    {
        //        using (AESHandler = new AesManaged())
        //        {
        //            AESHandler.Key = key;
        //            using (var encryptor = AESHandler.CreateEncryptor())
        //            {
        //                HashAlgorithm ls = SHA256CryptoServiceProvider.Create();
        //               // encryptor.
        //            }
        //        }
        //        return value;
        //    }
        //}

        //public class MD5
        //{
        //    public string Hash(string password)
        //    {
                
        //        var bytes = new UTF8Encoding().GetBytes(password);
        //        var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
        //        return Convert.ToBase64String(hashBytes);
        //    }
        //}

        public class BCryptHandler
        {
            private static string GetRandomSalt()
            {
                return BCrypt.Net.BCrypt.GenerateSalt(12);
            }

            public static string HashPassword(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
            }

            public static bool ValidatePassword(string password, string correctHash)
            {
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
        }
    }
}
