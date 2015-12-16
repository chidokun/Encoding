/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.Security.Cryptography;

namespace Encoding.Hash
{
    public class SHA512 : Hash
    {
        public SHA512(string source = "")
        {
            Source = source;
            hash = new SHA512CryptoServiceProvider();
        }
    }
}
