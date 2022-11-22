
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Code203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var dummyHead = new ListNode();
            dummyHead.next = head;
            var current = dummyHead;
            while(current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return dummyHead.next;

        }
    }

     
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
}
