using System;

namespace ReverseLinkList
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
    
    
    public static void PrintList(Node head)
    {
      while (head != null)
      {
        Console.Write(head.data + " -> ");
        head = head.next;
      }

      Console.WriteLine("null");
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