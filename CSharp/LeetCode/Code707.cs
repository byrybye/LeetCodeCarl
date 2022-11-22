using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode707
{
    public class MyLinkedList
    {
        private ListNode dummyHead = new ListNode();
        private int count = 0;

        public MyLinkedList()
        {
        }

        public int Get(int index)
        {
            if (index < 0 || index > count - 1)
            {
                return -1;
            }
            var current = dummyHead.next;

            for (int i = 0; i < index; i += 1)
            {
                current = current.next;
            }
            return current.val;
        }        

        public void AddAtHead(int val)
        {
            var newNode = new ListNode(val);
            newNode.next = dummyHead.next;
            dummyHead.next = newNode;
            count += 1;
        }

        public void AddAtTail(int val)
        {
            var current = dummyHead;
            while (current.next != null)
            {
                current = current.next;
            }
            var newNode = new ListNode(val);
            current.next = newNode;
            count += 1;
        }
       
        
        public void AddAtIndex(int index, int val)
        {            
            if (index < 0 || index > count )
            {
                return;
            }            
            var preNode = dummyHead;
            for (int i = 0; i < index; i += 1)
            {
                preNode = preNode.next;
            }
            
            ListNode newNode = new ListNode(val);
            newNode.next = preNode.next;
            preNode.next = newNode;
            count += 1;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > count - 1)
            {
                return;
            }            
            var preNode = dummyHead;
            for (int i = 0; i < index; i += 1)
            {
                preNode = preNode.next;
            }

            preNode.next = preNode.next.next;
            count -= 1;
        }

        public void Print()
        {
            var current = dummyHead.next;

            while(current.next != null)
            {
                Console.Write(current.val.ToString()+",");
                current = current.next;
            }
            Console.Write(current.val.ToString() + ",");
        }
        public void Test()
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddAtHead(1);
            linkedList.AddAtTail(3);
            linkedList.AddAtIndex(1, 2);   //链表变为1-> 2-> 3
            linkedList.Get(1);            //返回2
            linkedList.DeleteAtIndex(1);  //现在链表是1-> 3
            linkedList.Get(0);            //返回3
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    

}
