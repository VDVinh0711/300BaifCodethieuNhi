using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace NodeLinkList
{
    
    //Target Today
    // - Create LinkList (done)
    // - Delete Node  
    // - Insert  (done)
    // - Reverse
    public class Node {
        public int val;
        public Node next;
        public Node(int x) { val = x; }
    }
    internal class Program
    {



        #region Utils

        public static void InitLinkList(Node head, int quantity)
        {
            Node cur = head;
            for (int i = 1; i < quantity; i++)
            {
                cur.next = new Node(i);
                cur = cur.next;
            }
        }
        public static int  GetLengthOfLinkList(Node head , int i=0)
        {
            if (head == null) return i;
            i += 1;
            return GetLengthOfLinkList(head.next, i);
        }
        public static void ShowLinkList(Node head)
        {
            if(head == null) return;
            Console.WriteLine(head.val);
            ShowLinkList(head.next);
        }
        public static bool IsHasValueInLinkList(Node head, int value, out int index)
        {
            int i = 0;
            Node cur = head;
            while (cur!= null)
            {
                if (cur.val == value)
                {
                    index = i;
                    return true;
                }

                i++;
                cur = cur.next;
            }

            index = -1;
            return false;
        }

        #endregion
        
        #region Insert Node
        public static void InsertAtTheEnd(Node head, Node nodeInsert)
        {
            Node cur = head;
            while (cur.next !=null)
            {
                cur = cur.next;
            }
            cur.next = nodeInsert;
        }
        public static void InsertAtBegin(ref Node head, Node nodeInsert)
        {
            nodeInsert.next = head;
            head = nodeInsert;
        }
        public static void InsertAtIndex(ref Node head, Node nodeInsert, int index)
        {
            int lengthOfList = GetLengthOfLinkList(head);
            if(index > lengthOfList) return;
            if (index == lengthOfList)
            {
                InsertAtTheEnd(head,nodeInsert);
            }
            else if (index == 0)
            {
                InsertAtBegin(ref head , nodeInsert);
            }
            else
            {
                Node cur = head;
                int i = 0;
                while (i < index)
                {
                    cur = cur.next;
                    i++;
                }
                nodeInsert.next = cur.next;
                cur.next = nodeInsert;
            }
            
            
        }
        
        #endregion

        #region Delete Node
        public static void DeleteAtBegin(ref Node head)
        {
            head = head.next;
        }
        public static void DeleteNodeAtTheEnd(ref Node head)
        {
            Node cur = head;
            while (cur.next.next != null)
            {
                cur = cur.next;
            }

            cur.next = null;
        }
        public static void DeleteNodeWithValue(ref Node head, int valueDelete)
        {
            bool isHasValue = IsHasValueInLinkList(head, valueDelete,out int index);
            int lenght = GetLengthOfLinkList(head);
            if(!isHasValue) return;
            if (head.val == valueDelete)
            {
                DeleteAtBegin(ref head);
            }
            else if(index == lenght-1)
            {
                DeleteNodeAtTheEnd(ref head);
            }
            else
            {
                Node cur = head;
                while (cur.next != null)
                {
                    if (cur.next.val == valueDelete)
                    {
                            cur.next = cur.next.next;
                    }
                    cur = cur.next;
                }
            }
        }
        #endregion


        #region Another Part

        public static void ReverseLinkList(ref Node head)
        {
            Node preNode =null;
            Node cur = head;
            while(cur != null)
            {
                Node nextNode = cur.next;
                cur.next = preNode;
                preNode = cur;
                cur = nextNode;
            }
            head = preNode;
            
        }
        
        
        public static  Node ReverseList(Node head) {
            Node prev = null;
            Node current = head;
            while (current != null) {
                Node nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }
            return prev;
        }
        // Check CirCle Of Link List
        public static bool CheckCircleOfLinkList(ref Node head)
        {
            Node cur = head;
            int valueStar = head.val;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            return  head.val == cur.val;
        }


        public static void Connect2LinkList(ref Node List1, ref Node List2)
        {
            Node cur = List1;
            while (cur.next != null)
            {
                cur = cur.next;
            }

            cur.next = List2;
        }


        public static bool IsPalindrome(Node head)
        {
            // List<int> cachesValue = new List<int>();
            // Node cur = head;
            // while (cur != null)
            // {
            //     cachesValue.Add(cur.val);
            //     cur = cur.next;
            // }
            // int left = 0;
            // int right = cachesValue.Count - 1;
            // while (left<right)
            // {
            //     if (cachesValue[left] != cachesValue[right])
            //     {
            //         return false;
            //     }
            //
            //     left++;
            //     right--;
            // }
            // return true;
            
            if (head == null || head.next == null)
                return true;
        
            // Tìm điểm giữa của danh sách
            Node slow = head;
            Node fast = head;
            while (fast.next != null && fast.next.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }
            Console.WriteLine(slow.next.val);
        
            // Đảo ngược nửa sau của danh sách
            Node secondHalf = ReverseList( slow.next);
        
            // So sánh nửa đầu với nửa sau đã đảo ngược
            Node firstHalf = head;
            while (secondHalf != null) {
                if (firstHalf.val != secondHalf.val)
                    return false;
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }
        
            return true;
        }
        #endregion
        
        
        public static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(1);
            head.next.next = new Node(2);
            head.next.next.next = new Node(1);
            head.next.next.next.next = new Node(3);
            head.next.next.next.next.next = new Node(4);
            head.next.next.next.next.next.next = new Node(5);
            head.next.next.next.next.next.next.next = new Node(6);

            ShowLinkList(head);
            
            

            Console.WriteLine(IsPalindrome(head));
          
           // ReverseLinkList(ref head);
         
           


        }
    }
}