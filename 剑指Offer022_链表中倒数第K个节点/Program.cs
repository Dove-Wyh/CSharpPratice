using System;

namespace 剑指Offer022_链表中倒数第K个节点
{
    class Program
    {
        public class ListNode
        {
            public int value;
            public ListNode next;
            public ListNode(int value, ListNode next = null)
            {
                this.value = value;
                this.next = next;
            }
        };

        public static ListNode InitList(int length)
        {
            ListNode headNode = new ListNode(0);
            ListNode node = headNode;
            for (int i = 1; i < length; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }
            PrintList(headNode);
            return headNode;
        }

        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.value);
                Console.Write(" ");
                node = node.next;
            }
            Console.WriteLine();
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || n == 0)
            {
                return null;
            }
            ListNode node1 = head;
            ListNode node2 = head;
            for (int i = 0; i < n; i++)
            {
                if (node1.next != null)
                {
                    node1 = node1.next;
                }
                else //走到这里说明倒数第n个节点为首节点,直接返回下一个即可
                {
                    return head.next;
                }
            }
            while (node1.next != null)
            {
                node1 = node1.next;
                node2 = node2.next;
            }
            node2.next = node2.next.next;
            return head;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WTF");
            PrintList(RemoveNthFromEnd(InitList(10), 4));
            PrintList(RemoveNthFromEnd(InitList(2), 2));
        }
    }
}
