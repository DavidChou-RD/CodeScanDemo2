using System;
using System.Collections.Generic;

namespace CodeScanDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SetTowResult();
        }

        public static void SetTowResult()
        {
            var arr = new int[] { 2, 17, 7, 15 };
            var result = TwoSum(arr, 9);
            Console.WriteLine($"Two sum of 9 is {arr[result[0]]} and {arr[result[1]]}. Indexes are {result[0]} and {result[1]}");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return new int[] { };
        }
    }
}
