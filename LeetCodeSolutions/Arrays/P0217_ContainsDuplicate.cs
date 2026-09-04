using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class P0217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
               
                if (!seen.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
