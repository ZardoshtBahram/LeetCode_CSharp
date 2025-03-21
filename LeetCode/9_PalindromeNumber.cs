using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _9_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            bool IsPalin = true;
            string str = x.ToString();

            for (int i = 0; i < str.Length/2; i++) 
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    IsPalin = false;
                    break;
                }
                
            }
            return IsPalin;
        }
    }
}
