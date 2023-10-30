using System;
using System.IO;
using System.Collections.Generic;
namespace Learn1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Solution sol = new Solution();
            ListNode l1l1 = new ListNode(2);
            ListNode l1l2 = new ListNode(4, l1l1);
            ListNode l1l3 = new ListNode(3, l1l2);
            ListNode l2l1 = new ListNode(5);
            ListNode l2l2 = new ListNode(6, l2l1);
            ListNode l2l3 = new ListNode(4, l2l2);
            Console.WriteLine(sol.getNumber(sol.getListNode(53)));
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

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentl1 = l1;
            ListNode currentl2 = l2;
            return l1;
        }
        public int getNumber(ListNode l1)
        {
            int res = 0;
            int teenPow = 1;
            List<int> numbers = new List<int>();
            ListNode current = l1;
            for (int i = 0; true; i++)
            {
                if (current == null)
                {
                    break;
                }
                numbers.Add(current.val);
                current = current.next;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                res += numbers[i]*teenPow;
                teenPow = teenPow * 10;
            }
            return res;
        }
        public ListNode getListNode(int num1)
        {
            string needAdd = $"{num1}"; 
            List<ListNode> nodes = new List<ListNode>(5);
            for (int i = 0; i<needAdd.Length; i++)
            {
                if (i < 2)
                {
                    nodes.Add(new ListNode(Parsing(needAdd[i])));
                    
                }
                else
                {
                    nodes.Add(new ListNode(Parsing(needAdd[i]), nodes[nodes.Count - 1]));
                }
               
            }
            return nodes[nodes.Count - 1];
        }
        public int Parsing(char num)
        {
            switch (num)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return int.MinValue;
            }
        }
    }
}
