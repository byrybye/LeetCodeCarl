using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code27
    {
        /// <summary>
        /// 双指针 感觉需要 N的平方 或 对数 的复杂，
        /// 要求 N 的复杂度解决，需要考虑双指针
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int slow = 0;
            int fast = 0;
            for(fast = 0; fast < nums.Length; fast++)
            {
                if(nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow += 1;
                }
            }
            return slow;
        }
    }
}
