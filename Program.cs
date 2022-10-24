using System.Collections;
public class Program
{
  public class Node
  {
    public Node next;
    public object data;
  }
  public class MyStack
  {
    Node top;
    public bool IsEmpty()
    {
      return top == null;
    }
    public void Push(object ele)
    {
      Node n = new Node();
      n.data = ele;
      n.next = top;
      top = n;
    }
    public Node Pop()
    {
      if (top == null)
        return null;
      Node d = top;
      top = top.next;
      return d;
    }
    public object Peek(int index){
      MyStack temp = new MyStack();
      object data = 0;
      int i = -1;
      do{
        data = Pop().data;
        temp.Push(data);
        i++;
      }while(i!=index);
      while(!temp.IsEmpty())
        Push(temp.Pop().data);
      return data;
    }
  }
  public class Node2
  {
    public Node2 prev, next;
    public object data;
  }
  public class MyQueue
  {
    Node2 rear, front; public bool IsEmpty()
    {
      return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
      Node2 n = new Node2();
      n.data = ele;
      if (rear == null)
      {
        rear = n; front = n;
      }
      else
      {
        rear.prev = n;
        n.next = rear; rear = n;
      }
    }
    public Node2 Dequeue()
    {
      if (front == null) return null;
      Node2 d = front;
      front = front.prev;
      if (front == null)
        rear = null;
      else
        front.next = null;
      return d;
    }
  }
  static int SumStack(MyStack ms){
    int sum = 0;
    MyStack temp = new MyStack();
    while(!ms.IsEmpty()){
      int t = (int)ms.Pop().data;
      sum += t;
      temp.Push(t);
    }
    while(!temp.IsEmpty())
      ms.Push((int)temp.Pop().data);
    return sum;
  }
  /*static int SumQueue(in MyQueue mq){

  }*/
  static int FindMaxStack(MyStack ms){
    int max = (int)ms.Pop().data;
    MyStack temp = new MyStack();
    while(!ms.IsEmpty()){
      int t = (int)ms.Pop().data;
      temp.Push(t);
      if(max<t)
        max = t;
    }
    while(!temp.IsEmpty())
      ms.Push((int)temp.Pop().data);
    return max;
  }
  public static void Main()
  {
    Console.Clear();

    MyStack ms = new MyStack();
    ms.Push(1);
    ms.Push(9);
    ms.Push(3);
    ms.Push(5);
    System.Console.WriteLine(ms.Peek(2));
    /*System.Console.WriteLine(FindMaxStack(ms));
    System.Console.WriteLine(ms.IsEmpty());*/
    /*ms.Pop();
    ms.Pop();

    MyQueue mq = new MyQueue();
    mq.Enqueue(1);
    mq.Enqueue(2);
    mq.Enqueue(3);
    mq.Dequeue();
    mq.Dequeue();*/

    Console.ReadLine();
  }
}
