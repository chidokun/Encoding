using System.Security.Cryptography;
using System.Text;

namespace Encoding.Cipher
{
    public class AES : Symmetric
    {
        public AES(string source = "", string key = "")
        {
            Source = source;
            Key = key;
            cryptoProvider = new AesCryptoServiceProvider();
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
