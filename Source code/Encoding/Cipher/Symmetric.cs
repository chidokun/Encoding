using System.IO;
using System.Security.Cryptography;
using System;

namespace Encoding.Cipher
{
    /// <summary>
    /// Represent base class for symmetric algorithm
    /// </summary>
    public abstract class Symmetric
    {
        public string Source { get; set; }

        public string Key { get; set; }

        protected SymmetricAlgorithm cryptoProvider;

        protected byte[] byteKey;
        protected byte[] byteIV;

        public virtual string Encode()
        {
            if (string.IsNullOrEmpty(Source))
            {
                throw new ArgumentNullException();
            }

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateEncryptor(byteKey, byteIV), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream);

            writer.Write(Source);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public virtual string Decode()
        {
            if (String.IsNullOrEmpty(Source))
            {
                throw new ArgumentNullException();
            }

            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(Source));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoProvider.CreateDecryptor(byteKey, byteIV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }

        public virtual bool ValidKey()
        {
            return cryptoProvider.ValidKeySize(System.Text.Encoding.UTF8.GetByteCount(Key) * 8);
        }
    }
}
