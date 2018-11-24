using DataStructures;
using System;
using System.Collections.Generic;

namespace DSOperations
{
    public class LinkedListNodeOperations
    {
        public LinkedListNode GetNewList()
        {
            LinkedListNode node = new LinkedListNode();
            LinkedListNode next = node;
            string Choice = "y";
            int count = 1;
            while (Choice.Equals("y"))
            {
                Console.Write(string.Format("Enter Elements in the List at {0} position: ", count));
                next.Value = int.Parse(Console.ReadLine());
                count++;
                Console.Write("Continue Y/N: ");
                Choice = Console.ReadLine().ToLower();
                if (Choice == "y")
                {
                    next.Next = new LinkedListNode();
                    next = next.Next;
                }
            }
            return node;
        }

        public string PrintList(LinkedListNode node)
        {
            string result = string.Empty;
            while (node != null)
            {
                if (node.Next != null)
                {
                    result += node.Value.ToString() + " -> ";
                }
                else
                {
                    result += node.Value.ToString();
                }
                
                node = node.Next;
            }
            return result;
        }

        public LinkedListNode Partition(LinkedListNode node, int data)
        {
            LinkedListNode head = node;
            LinkedListNode tail = node;
            while (node != null)
            {
                LinkedListNode next = node.Next;
                if(node.Value < data)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
                node = next;
            }
            tail.Next = null;
            return head;
        }

        public bool IsPalindrome(LinkedListNode head)
        {
            LinkedListNode fast = head;
            LinkedListNode slow = head;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Value);
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            if (fast != null)
            {
                slow = slow.Next;
            }
            while (stack.Count > 0)
            {
                int data = stack.Pop();
                if (data != slow.Value)
                    return false;
                slow = slow.Next;
            }
            return true;
        }

        public LinkedListNode Reverse(LinkedListNode head)
        {
            LinkedListNode reverse = null;
            while (head != null)
            {
                LinkedListNode pointer = new LinkedListNode(head.Value);
                pointer.Next = reverse;
                reverse = pointer;
                head = head.Next;
            }
            return reverse;
        }
    }
}
