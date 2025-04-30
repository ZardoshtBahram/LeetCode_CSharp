using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2799
    {
        public int CountCompleteSubarrays(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in nums) 
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else 
                    dic.Add(i, 1);
            }

            int result = 0;

            for (int j = 0; j < dic.Count; j++) 
            {
                result += FactorialRecursive(dic[j]);
            }

            return result;
        }

        static int FactorialRecursive(int n)
        {
            if (n < 0) throw new ArgumentException("n must be non-negative", nameof(n));
            return n <= 1 ? 1 : n * FactorialRecursive(n - 1);
        }


    }
}
