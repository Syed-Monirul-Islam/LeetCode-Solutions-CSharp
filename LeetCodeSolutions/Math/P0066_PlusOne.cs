using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Math
{
    public class P0066_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
               
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

              
                digits[i] = 0;
            }

           
            int[] result = new int[n + 1];
            result[0] = 1;

            return result;
        }
    }
}
