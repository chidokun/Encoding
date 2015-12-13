using System.Security.Cryptography;
using System.Text;

namespace Encoding.Cipher
{
    public class RC2 : Symmetric
    {
        public RC2(string source = "", string key = "")
        {
            Source = source;
            Key = key;
            cryptoProvider = new RC2CryptoServiceProvider();
        }

        public override string Encode()
        {
            byteKey = UTF8Encoding.UTF8.GetBytes(Key);
            if (byteKey.Length == cryptoProvider.BlockSize)
                byteIV = byteKey;
            else
            {
                byteIV = new byte[cryptoProvider.BlockSize];
                if (byteIV.Length > byteKey.Length)
                {
                    int i = 0;
                    while (i < byteKey.Length)
                    {
                        byteIV[i] = byteKey[i];
                        i++;
                    }
                    while (i < byteIV.Length)
                    {
                        byteIV[i] = 0;
                        i++;
                    }
                }
                else
                {
                    for (int i = 0; i < byteIV.Length; i++)
                        byteIV[i] = byteKey[i];
                }
            }
            return base.Encode();
        }

        public override string Decode()
        {
            byteKey = UTF8Encoding.UTF8.GetBytes(Key);
            if (byteKey.Length == cryptoProvider.BlockSize)
                byteIV = byteKey;
            else
            {
                byteIV = new byte[cryptoProvider.BlockSize];
                if (byteIV.Length > byteKey.Length)
                {
                    int i = 0;
                    while (i < byteKey.Length)
                    {
                        byteIV[i] = byteKey[i];
                        i++;
                    }
                    while (i < byteIV.Length)
                    {
                        byteIV[i] = 0;
                        i++;
                    }
                }
                else
                {
                    for (int i = 0; i < byteIV.Length; i++)
                        byteIV[i] = byteKey[i];
                }
            }
            return base.Decode();
        }
    }
}
