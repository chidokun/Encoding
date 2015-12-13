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
