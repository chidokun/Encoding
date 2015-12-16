/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.Security.Cryptography;

namespace Encoding.Hash
{
    public class SHA : Hash
    { 
        public SHA(string source = "")
        {
            Source = source;
            hash = new SHA1CryptoServiceProvider();
        }
    }
}
