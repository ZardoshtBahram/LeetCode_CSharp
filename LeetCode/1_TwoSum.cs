﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
        
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = i+1; j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == target) 
                        return new int[] { i, j };
                   
                }
                
            }
            return null;

            
        }
    }
}
