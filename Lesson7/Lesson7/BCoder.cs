using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class BCoder : ICoder
    {
        public string Encode(string str)
        {
            string cipherText = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.IndexOf(str[i]) == 0)
                {
                    cipherText += (char)(str[i] + 31);
                }
                else    
                cipherText += (char)(str [i] + (31 - (str.IndexOf(str[i])*2)));
            }
            return cipherText;
        }
        public string Decod(string str)
        {
            string decryptedЕText = "";
            for (int i = 0; i < str.Length; i++)
            decryptedЕText += (char)(str[i] - (31 - (str.IndexOf(str[i]) * 2)));
            return decryptedЕText;
        }
    }
}
//1