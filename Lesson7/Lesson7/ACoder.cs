using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class ACoder : ICoder
    {
        public string Encode(string str)
        {
            string cipherText = "";
            for (int i = 0; i < str.Length; i++) 
            cipherText += (char)(str[i] + 1);
            return cipherText;
        }
        public string Decod(string str)
        {
            string decryptedЕText = "";
            for (int i = 0; i < str.Length; i++) 
            decryptedЕText += (char)(str[i] - 1);
            return decryptedЕText;
        }
    }
}
//1