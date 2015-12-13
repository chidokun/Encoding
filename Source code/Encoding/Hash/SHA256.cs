using System.Security.Cryptography;

namespace Encoding.Hash
{
    public class SHA256 : Hash
    {
        public SHA256(string source="")
        {
            Source = source;
            hash = new SHA256CryptoServiceProvider();
        }
    }
}
