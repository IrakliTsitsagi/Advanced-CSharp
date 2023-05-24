﻿using System.Security.Cryptography;
using System.IO;

namespace CryptographyApp
{
    internal class CryptographyApp
    {
        static void Main(string[] args)
        {
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter your message");
            string plainText = Console.ReadLine();

            // string cipherText = ""; encrypt
            string cipherText = Encrypt(plainText, key); // decrypt

            Console.WriteLine("\nCipher Text: " + Encrypt(plainText,key));
            Console.WriteLine("Plain Text: " + Decrypt(cipherText, key));
        }

        public static string Encrypt(string plainText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(plainText);
            sw.Flush();
            cs.FlushFinalBlock();
            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
        }

        public static string Decrypt(string cipherText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}