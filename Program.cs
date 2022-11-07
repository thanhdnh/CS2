using System;
using System.Collections.Generic;
public class Program
{
  public class Node
  {
    public object element;
    public Node link;
    public Node()
    {
      element = null;
      link = null;
    }
    public Node(object element)
    {
      this.element = element;
      link = null;
    }
  }
  public class LinkedList
  {
    public Node header;
    public LinkedList()
    {
      header = new Node("Header");
    }
    private Node Find(object element)
    {
      Node current = new Node();
      current = header;
      while (current.element != element)
        current = current.link;
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node current = new Node();
      Node newnode = new Node(newelement);
      current = Find(afterelement);
      newnode.link = current.link;
      current.link = newnode;
    }
    public Node FindPrev(object element)
    {
      Node current = header;
      while (current.link != null && current.link.element != element)
        current = current.link;
      return current;
    }
    public void Remove(object element)
    {
      Node current = FindPrev(element);
      if (current.link != null)
        current.link = current.link.link;
    }
    public void Print()
    {
      Node current = new Node();
      current = header;
      while (current.link != null)
      {
        Console.WriteLine(current.link.element);
        current = current.link;
      }
    }
    public void InsertFirst(object newelement)
    {
      Node newnode = new Node(newelement);
      newnode.link = header.link;
      header.link = newnode;
    }
    public void InsertLast(object newelement)
    {
      Node newNode = new Node();
      Node current = header;
      newNode.element = newelement;
      while (current.link != null)
      {
        current = current.link;
      }
      current.link = newNode;

    }
    public void InsertBefore(object newelement, object beforeelement)
    {
      Node newnode = new Node(newelement);
      Node current = header;
      while (current.link.element != beforeelement)
        current = current.link;
      newnode.link = current.link;
      current.link = newnode;
    }
    public int FindMax()
    {
      Node current = header.link;
      int max = int.Parse(current.element.ToString());
      while (current.link != null)
      {
        current = current.link;
        if (max < int.Parse(current.element.ToString()))
          max = int.Parse(current.element.ToString());
      }
      return max;
    }
  }

  public class Node2
  {
    public object element;
    public Node2 flink, blink;
    public Node2()
    {
      element = null;
      flink = blink = null;
    }
    public Node2(object element)
    {
      this.element = element;
      flink = blink = null;
    }
  }

  public class DoubleLinkedList
  {
    public Node2 header;
    public DoubleLinkedList()
    {
      header = new Node2("Header");
    }
    private Node2 Find(object element)
    {
      Node2 current = new Node2();
      current = header;
      while (current.element != element)
      {
        current = current.flink;
      }
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node2 current = new Node2();
      Node2 newnode = new Node2(newelement);
      current = Find(afterelement);
      newnode.flink = current.flink;
      newnode.blink = current;
      current.flink = newnode;
    }
    public void Remove(object element)
    {
      Node2 current = Find(element);
      if (current.flink != null)
      {
        current.blink.flink = current.flink;
        current.flink.blink = current.blink;
        current.flink = null;
        current.blink = null;
      }
    }
    private Node2 FindLast()
    {
      Node2 current = new Node2();
      current = header;
      while (!(current.flink == null))
        current = current.flink;
      return current;
    }
    public void Print()
    {
      Node2 current = new Node2();
      current = FindLast();
      while (!(current.blink == null))
      {
        Console.WriteLine(current.element);
        current = current.blink;
      }
    }
  }
  static void Main()
  {
    Console.Clear();
    LinkedList list = new LinkedList();
    list.Insert("1", "Header");
    list.InsertFirst("13");
    list.InsertLast("11");
    list.InsertBefore("15", "11");
    list.InsertFirst(27);
    list.InsertLast(25);
    list.Print();
    System.Console.WriteLine("Max of LL: " + list.FindMax());


    Console.ReadLine();
  }
}