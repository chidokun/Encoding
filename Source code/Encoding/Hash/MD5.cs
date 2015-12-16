/*
Encoding - A mini tool to encrypt and decrypt a plain-text
Copyright (c) 2015 - Nguyễn Tuấn
*/

using System.Security.Cryptography;

namespace Encoding.Hash
{
    public class MD5 : Hash
    {
        public MD5(string source = "")
        {
            Source = source;
            hash = new MD5CryptoServiceProvider();
        }
    }
}
