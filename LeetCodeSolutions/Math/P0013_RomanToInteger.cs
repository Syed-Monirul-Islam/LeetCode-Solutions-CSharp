using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Math
{
    public class P0013_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
             {
                 {'I',1 },
                 {'V',5 },
                 {'X',10 },
                 {'L',50 },
                 {'C',100 },
                 {'D',500 },
                 {'M',1000 },
             };
            int total = 0;
            for(int i=0;i<s.Length; i++)
            {
                int currentVal = romanMap[s[i]];
                if(i + 1<s.Length && currentVal < romanMap[s[i +1]])
                {
                    total -= currentVal;

                }
                else
                {
                    total += currentVal;
                }
            }
            return total;

        }
    }
}
