/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.Security.Cryptography;

namespace Encoding.Hash
{
    public class SHA384 :Hash
    {
        public SHA384(string source="")
        {
            Source = source;
            hash = new SHA384CryptoServiceProvider();
        }
    }
}
