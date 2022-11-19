using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code704
    {
        /// <summary>
        /// 因为是单个区间问题 所以使用 左闭右闭 区间
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            int left = 0;
            int right = nums.Length - 1;
            //因为 是左闭右闭区间 所以 是 <=
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target < nums[middle])
                {
                    right = middle - 1;  //闭区间 所以边界应该是 middle - 1 
                }
                else if (target > nums[middle])
                {
                    left = middle + 1;   //闭区间 所以边界应该是 middle + 1 
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        public void Test()
        {
            int[] mums = { 5 };
            var index = Search(mums, -5);
            Console.WriteLine(index);

        }
    }
}
