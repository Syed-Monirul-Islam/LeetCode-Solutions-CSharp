using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Arrays
{
    public class P0119_PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> row = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                
                row.Add(1);
            
                for (int j = i - 1; j > 0; j--)
                {
                    row[j] = row[j] + row[j - 1];
                }
            }

            return row;
        }
    }
}
