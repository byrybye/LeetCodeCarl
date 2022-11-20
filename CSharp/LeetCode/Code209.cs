using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int result = int.MaxValue;            
            int start = 0;
            int sum = 0;
            int length = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                sum += nums[end];
                if (sum >= target)
                {
                    while(sum >= target) //开始 滑动 这是 精髓
                    {
                        length = end - start + 1;
                        result = Math.Min(result, length);

                        sum -= nums[start]; // 开始位置开始向后移动 关键
                        start += 1;
                    }
                }
            }
            return result ==int.MaxValue ? 0 : result;
        }


        [TestMethod]
        public void Test()
        {
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            var result = MinSubArrayLen(target, nums);
            Console.WriteLine(result);
        }


    }
}
