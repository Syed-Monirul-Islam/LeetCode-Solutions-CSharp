using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Math
{
    public class P0067_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum += a[i] - '0'; 
                    i--;
                }

                if (j >= 0)
                {
                    sum += b[j] - '0';
                    j--;
                }

                
                sb.Append(sum % 2);

                
                carry = sum / 2;
            }

            
            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
