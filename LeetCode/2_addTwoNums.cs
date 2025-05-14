using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
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

    internal class _2_addTwoNums
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            long result = 0;
            int multiplier = 1;

            while (l1 != null)
            {
                result += l1.val * multiplier;
                l1 = l1.next;
                multiplier *= 10;
            }

            multiplier = 1;

            while (l2 != null)
            {
                result += l2.val * multiplier;
                l2 = l2.next;
                multiplier *= 10;
            }


            ListNode head = null;
            ListNode tail = null;

            if (result == 0)
                return new ListNode(0);

            while (result > 0) 
            {
                long digit = result % 10;
                result /= 10;

                ListNode newnode = new ListNode((int)digit);
                if (head == null)
                    head = tail = newnode;

                else 
                {
                    tail.next = newnode;
                    tail = tail.next;
                }

            }

            return head;
        }
    }
}
