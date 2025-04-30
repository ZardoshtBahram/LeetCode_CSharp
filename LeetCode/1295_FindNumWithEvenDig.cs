using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1295_FindNumWithEvenDig
    {
        public int FindNumbers(int[] nums)
        {
            int result = 0;
            foreach (int num in nums) 
            {
                int i = num;

                while (i > 9) 
                {
                    i = i/10;
                    if (i < 10)
                    {
                        result++;
                        break;
                    }
                    else 
                    {
                        i = i / 10;
                    }
                    

                }
            }

            return result;
        }
    }
}
