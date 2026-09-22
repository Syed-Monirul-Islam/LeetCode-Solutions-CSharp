using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Math
{
    public class P0171_ExcelSheetColumnNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;

            foreach (char c in columnTitle)
            {
                
                int value = c - 'A' + 1;

               
                result = (result * 26) + value;
            }

            return result;
        }
    }
}
