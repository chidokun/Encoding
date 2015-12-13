using System.Security.Cryptography;
using System.Text;

namespace Encoding.Cipher
{
    public class TripleDES : Symmetric
    {
        public TripleDES(string source = "", string key = "")
        {
            Source = source;
            Key = key;
            cryptoProvider = new TripleDESCryptoServiceProvider();
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

        private bool IsWeakKey()
        {
            byte[] key = UTF8Encoding.UTF8.GetBytes(Key);
            return System.Security.Cryptography.TripleDES.IsWeakKey(key);
        }

        public override bool ValidKey()
        {
            return !IsWeakKey() && base.ValidKey();
        }
    }
}
