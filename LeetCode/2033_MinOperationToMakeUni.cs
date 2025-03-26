using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2033_MinOperationToMakeUni
    {
        public int MinOperations(int[][] grid, int x)
        {
            int[] sorted1D = grid.SelectMany(row => row).OrderBy(n=>n).ToArray();

            int operationCount = 0;
            int commonMod = -1 ;

            int mid = sorted1D[sorted1D.Length/2];

            for (int i = 0; i < sorted1D.Length; i++) 
            {
                if (commonMod == -1)
                    commonMod = sorted1D[i] % x;

                if (commonMod != sorted1D[i] % x)
                {
                    return -1;
                }
                else 
                {
                    operationCount += Math.Abs((mid - sorted1D[i])/ x);
                }

                
            }

            return operationCount;
        }
    }
}
