using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code704
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length < 1)
            {
                return -1;
            }

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target < nums[middle])
                {
                    right = middle - 1;
                }
                else if (target > nums[middle])
                {
                    left = middle + 1;
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
