﻿using System;

namespace HouseRobber
{
    public class Solution {
        public static int Rob(int[] nums) {
            var dp=new int[nums.Length+1];
        
            dp[0]=0;
            dp[1]=nums[0];
        
            for(int i=1;i<nums.Length;i++){
                dp[i+1] = Math.Max(dp[i],nums[i] + dp[i-1]);
            }
        
            return dp[nums.Length];
        }
    
    
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var nums = new[] {2,1,1,2};
            Console.WriteLine(Solution.Rob(nums));
        }
    }
}