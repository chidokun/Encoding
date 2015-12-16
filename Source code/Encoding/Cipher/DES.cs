/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.Security.Cryptography;
using System.Text;

namespace Encoding.Cipher
{
    public class DES : Symmetric
    {
        public DES(string source = "", string key = "")
        {
            Source = source;
            Key = key;
            cryptoProvider = new DESCryptoServiceProvider();
        }

        public override string Encode()
        {
            byteKey = UTF8Encoding.UTF8.GetBytes(Key);
            byteIV = byteKey;
            return base.Encode();
        }

        public override string Decode()
        {
            byteKey = UTF8Encoding.UTF8.GetBytes(Key);
            byteIV = byteKey;
            return base.Decode();
        }
    }
}
