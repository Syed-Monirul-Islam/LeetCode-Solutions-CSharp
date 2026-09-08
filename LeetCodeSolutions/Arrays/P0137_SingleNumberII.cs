using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class P0137_SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);

            
            for (int i = 0; i < nums.Length - 1; i += 3)
            {
               
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return nums[nums.Length - 1];
        }
    }
}
