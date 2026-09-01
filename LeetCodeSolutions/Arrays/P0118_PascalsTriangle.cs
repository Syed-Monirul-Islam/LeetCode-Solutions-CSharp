using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class P0118_PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                    
                        int val = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        row.Add(val);
                    }
                }

                triangle.Add(row);
            }

            return triangle;
        }
    }
}
