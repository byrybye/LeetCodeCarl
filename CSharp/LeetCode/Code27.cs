using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code27
    {
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
