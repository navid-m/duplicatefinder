using System.IO;
using System.Security.Cryptography;

namespace Duplicatefinder
{
    public class HashManager
    {
        private readonly MD5 mdf;

        public HashManager()
        {
            mdf = new MD5CryptoServiceProvider();
        }

        public string GetHash(string fname)
        {
            string res = "";
            try
            {
                FileStream fle = new FileStream(fname, FileMode.Open);
                byte[] retv = mdf.ComputeHash(fle); 
                fle.Close();
                foreach (byte ret in retv)
                {
                    res += ret.ToString();
                }
            } catch (System.UnauthorizedAccessException) { res = null; }
            return res;
        }
    }
}
