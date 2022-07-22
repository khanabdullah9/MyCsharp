﻿using System;
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

        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val; 
            this.next = next;
        }
    }  
    internal class TwoNumbersLL
    {
        public ListNode Solution(ListNode l1, ListNode l2) 
        {
            ListNode dummy = new ListNode();
            ListNode temp = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null) 
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                carry = sum / 10;
                ListNode node = new ListNode(sum % 10);
                temp.next = node;
                temp = temp.next;
            }
            return dummy.next;//the dummy node holds the linked list which is the sum (but in reverse as expectedj)
        }
    }
}
