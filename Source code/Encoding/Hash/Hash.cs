using System.Security.Cryptography;
using System.Text;

namespace Encoding.Hash
{
    /// <summary>
    /// Represent base class for hash algorithm
    /// </summary>
    public abstract class Hash
    {
        public string Source { get; set; }

        protected HashAlgorithm hash;

        public virtual string Encode()
        {
            byte[] byteSource = System.Text.Encoding.Default.GetBytes(Source);
            byte[] byteResult = hash.ComputeHash(byteSource);

            StringBuilder result = new StringBuilder();

            foreach (byte i in byteResult)
            {
                result.Append(i.ToString("x2"));
            }

            return result.ToString();
        }

    }
}
