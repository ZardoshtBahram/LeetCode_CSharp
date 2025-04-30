using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _763_PartitionLabels
    {
        public IList<int> PartitionLabels(string s)
        {
            int prevI = 0;
            int startI = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < s.Length ; i++) 
            {
                int endI = 0;
                for (int j = s.Length -1 ; j >= i; j--) 
                {
                    if (s[i] == s[j]) 
                    {
                        endI = j;
                        break;
                    }
                }

                if (endI > prevI)
                {
                    prevI = endI;
                }

                if (i == prevI) 
                {
                    result.Add(prevI - startI + 1);
                    prevI = i + 1;
                    startI = i + 1;
                }
            }

            return result;
        }
    }
}
