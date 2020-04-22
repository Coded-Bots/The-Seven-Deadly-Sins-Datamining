using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LocalAssetsManager
{
    class Program
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            Console.WriteLine(hex.ToString());
            return hex.ToString();
        }
        public static byte[] DeriveKeyInitVector(string password, byte[] salt, byte[] encryptedData)
        {
            byte[] iv = new byte[0x10];
            byte[] key;
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt);
            var k = keyGenerator.GetBytes(8);
            key = keyGenerator.GetBytes(0x20);
            Array.Copy(k, 0, iv, 0, 8);
            Array.Copy(salt, 8, iv, 8, 8);
            ByteArrayToString(key);
            ByteArrayToString(iv);
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            using (ICryptoTransform decryptor = rijndaelCipher.CreateDecryptor(key, iv))
            {
                using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        byte[] plainText = new byte[encryptedData.Length];
                        int decryptedCount = cryptoStream.Read(plainText, 0, plainText.Length);
                        byte[] head = new byte[encryptedData.Length - 0x20];
                        var unity = new byte[] { 0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x00, 0x00, 0x00, 0x00, 0x06, 0x35, 0x2E, 0x78, 0x2E };
                        Array.Copy(unity, head, unity.Length);
                        Array.Copy(plainText, 0x2f, head, 0xf, plainText.Length - 0x2f);
                        return head;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var t = File.ReadAllBytes(args[0]);
            Console.WriteLine(t.Length);
            byte[] salt = new byte[0x20];
            Array.Copy(t, 0, salt, 0, 0x20);
            ByteArrayToString(salt);
            var dec = DeriveKeyInitVector("z_RZT_2SshrdEkhtKSR8LyV7BJ7ghtFN", salt, t);
            File.WriteAllBytes(String.Format("{0}_dec", args), dec);
        }
    }
}