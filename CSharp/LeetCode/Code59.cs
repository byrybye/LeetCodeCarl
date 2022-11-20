using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code59
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            int start = 0;
            int end = n - 1;
            int count = 1;
            while (count < n * n)
            {
                //处理边 规则 采取 左闭右开 方式
                //处理上边 
                for (int i = start; i < end; i += 1)
                {
                    result[start][i] = count;
                    count += 1;
                }
                //处理右边
                for (int i = start; i < end; i += 1)
                {
                    result[i][end] = count;
                    count += 1;
                }
                //处理下边
                for (int i = end; i > start; i -= 1)
                {
                    result[end][i] = count;
                    count += 1;
                }
                //处理左边
                for (int i = end; i > start; i -= 1)
                {
                    result[i][start] = count;
                    count += 1;
                }
                start += 1;
                end -= 1;
            }
            if (n % 2 == 1) result[n / 2][n / 2] = count;
            return result;
        }
    }
}
