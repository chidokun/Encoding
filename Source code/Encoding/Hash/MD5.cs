using System.Security.Cryptography;
using System.Text;

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
