using System;
using System.Collections.Generic;

namespace largest_subarray_having_an_equal_number_of_0_s_and_1_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 0, 1, 0, 0 };
            findLargestSubarray(nums);
        }

        public static void findLargestSubarray(int[] nums)
        {
            int len = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int ending = -1;
            int sum = 0;
            dic.Add(0, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += (nums[i] == 0) ? -1 : 1;
                if (dic.ContainsKey(sum))
                {
                    // update length and ending index of largest subarray having zero-sum
                    if (len < i - dic[sum])
                    {
                        len = i - dic[sum];
                        ending = i;
                    }
                }
                // if the sum is seen for the first time, insert the sum with its
                // index into the map
                else
                {
                    dic.Add(sum, i);
                }
            }
            Console.WriteLine(ending-len+1+" "+ ending);
        }
    }
}
