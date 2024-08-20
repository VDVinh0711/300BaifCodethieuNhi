using System;

namespace LinkList
{
    public class Node {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }


    internal class Program
    {
        public static void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " -> ");
                head = head.next;
            }

            Console.WriteLine("null");
        }

        public static Node DeleteNode(Node head, int target)
        {

            if (head.next == null) return null;
            if (head.data == target)
            {
                head = head.next;
                return head;
            }

            Node current = head;
            while (current != null)
            {
                if (current.next.data == target)
                {
                    current.next = current.next.next;
                }

                current = current.next;
            }

            return head;
        }


        public static Node DeleteNodeFollowIndex(Node head, int index)
        {
            if (head == null) return null;


            Node cur = head;
            Node temp = head;
            int lengList = 0;
            while (cur != null)
            {
                lengList++;
                cur = cur.next;
            }

            int indexDelete = lengList - index;
            if (indexDelete == 0)
            {
                head = head.next;
                return head;
            }

            int j = 1;
            while (temp != null)
            {

                if (j == indexDelete)
                {
                    temp.next = temp.next.next;
                }

                j++;
                temp = temp.next;
            }

            return head;


        }



        public static Node ReverseList(Node head)
        {
            Node preNode = null;
            Node cur = head;
            while (cur != null)
            {
                Node nextNode = cur.next;
                cur.next = preNode;
                preNode = cur;
                cur = nextNode;
                
                Console.WriteLine(preNode.data);
            }

            return preNode;
        }
    

    public static void Main(string[] args)
        {
            Node head = new Node(1);
             head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);
            Console.WriteLine("Original list: ");
            PrintList(head);
            var nodeRevers = ReverseList(head);
            PrintList(nodeRevers);


        }
    }
}