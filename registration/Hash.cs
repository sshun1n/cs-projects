using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace registration
{
    internal class Hash
    {
        private string sourse = "";

        public Hash(string sourse) { this.sourse = sourse; }

        public string getHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(sourse);
                byte[] hashBytes = sha256.ComputeHash(sourceBytes);
                
                return BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }
        }
    }
}
