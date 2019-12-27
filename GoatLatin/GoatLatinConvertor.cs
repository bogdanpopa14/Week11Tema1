using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    public class GoatLatinConvertor
    {
        private string s;
        private string[] words;
        public GoatLatinConvertor(string input)
        {
            this.s = input;
            words = input.Split(' ');
        }
        
        public string ConvertToGoat()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string curent = words[i];
                if(curent[0]=='a'||curent[0]=='e'||curent[0]=='i' || curent[0] == 'o' || curent[0] == 'u')
                {
                    curent += "ma";
                    for (int j = 0; j <=i; j++)
                    {
                        curent += 'a';
                    }
                }
                if(curent[0] != 'a' && curent[0] != 'e' && curent[0] != 'i' && curent[0] != 'o' && curent[0] != 'u')
                {
                    char last = curent[0];
                    curent = curent.Substring(1, curent.Length - 1) + last;
                    curent += "ma";
                    for (int j = 0; j <= i; j++)
                    {
                        curent += 'a';
                    }

                }
                sb.Append(curent);
                if (i<words.Length-1)
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }

    }
}
