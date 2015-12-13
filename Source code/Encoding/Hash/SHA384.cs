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
