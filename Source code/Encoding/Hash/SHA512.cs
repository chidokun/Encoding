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
