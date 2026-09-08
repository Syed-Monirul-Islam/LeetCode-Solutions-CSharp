using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeSolutions.Arrays
{
    public class P0011_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxWater = 0;
            while(left<right)
            {
                int width = right - left;
                int currentHeight = System.Math.Min(height[left], height[right]);
                int currentArea  =width * currentHeight;

                maxWater = System.Math.Max(maxWater, currentArea);
                if (height[left] < height[right])
                {
                    left++;

                }
                else
                {
                    right--;
                }

            }

            return maxWater;
        }
    }
}
