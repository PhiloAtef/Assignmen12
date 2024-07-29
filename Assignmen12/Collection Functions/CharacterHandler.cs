using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen12.Collection_Functions
{
    internal class CharacterHandler
    {
        public static int NonRepeatingFirstCharIndex(String s)
        {
                s = s.ToLower();
                Dictionary<char, int> dict = new Dictionary<char, int>();

                foreach (char c in s) 
                {
                    if (dict.ContainsKey(c))
                    {
                        dict[c]++;
                    }
                    else
                    {
                        dict[c] = 1;
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (dict[s[i]] == 1)
                    {
                        return i;
                    }
                }
                return -1;
            }


    }
}
