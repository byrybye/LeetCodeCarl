using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode previouse = null;
            ListNode current = head;
            while(current != null)
            {
                //取出下一个节点
                ListNode next = current.next;
                //反转执行 当前节点 指向前一节点
                current.next = previouse;                
                
                //后移操作 
                previouse = current;
                current = next;
            }
            return previouse;
        }
    }
}
