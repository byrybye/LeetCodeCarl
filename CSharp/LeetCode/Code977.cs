using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code977
    {
        /// <summary>
        /// 双指针解题比较简单 
        /// 关键 需要分析出 最大值 只会出现在 首尾 两个位置
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int position = nums.Length - 1;
            while (left <= right)
            {
                if (nums[left]* nums[left] > nums[right]*nums[right] )
                {
                    result[position] = nums[left] * nums[left];
                    position -= 1;
                    left += 1;
                }
                else
                {
                    result[position] = nums[right] * nums[right];
                    position -= 1;
                    right -= 1;
                }                
            }
            return result;
        }

        public void Test()
        {
            
            int[] mums = { -4, -1, 0, 3, 10 };
            var result = SortedSquares(mums);
            Console.WriteLine(result);

        }
    }
}
