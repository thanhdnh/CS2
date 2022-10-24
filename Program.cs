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
  class Book{
    public string id;
    public string ten;
    public string tacgia;
    public int gia;
    public Book(string id, string ten, string tacgia, int gia){
      this.id = id;
      this.ten = ten;
      this.tacgia = tacgia;
      this.gia = gia;
    }
    public override string ToString()
    {
      return $"Book[id: {id}, Ten: {ten}, Tac gia: {tacgia}, Gia: {gia}]";
    }
  }
  static void PrintCurrentBook(Stack<Book> l, string id){
    Stack<Book> temp = new Stack<Book>();
    while(l.Count!=0){
      Book b = l.Pop();
      temp.Push(b);
      if(b.id.Equals(id)){
        System.Console.WriteLine(b);
        break;
      }
    }
    while(temp.Count!=0)
      l.Push(temp.Pop());
  }
  static void PrintNextBook(Stack<Book> l, string id){
    Stack<Book> temp = new Stack<Book>();
    while(l.Count!=0){
      Book b = l.Pop();
      temp.Push(b);
      if(b.id.Equals(id)){
        Book bb = l.Pop();
        temp.Push(bb);
        System.Console.WriteLine(bb);
        break;
      }
    }
    while(temp.Count!=0)
      l.Push(temp.Pop());
  }
  public static void Main()
  {
    Console.Clear();

    Stack<Book> kesach = new Stack<Book>();
    Book b1 = new Book("B01", "Toan A1", "Nguyen A", 25000);
    Book b2 = new Book("B02", "Tin hoc", "Le B", 22000);
    Book b3 = new Book("B03", "Kinh te", "Ngo C", 23000);
    Book b4 = new Book("B04", "Khoa hoc du lieu", "Tran D", 32000);
    kesach.Push(b1); kesach.Push(b2); kesach.Push(b3); kesach.Push(b4);
    PrintCurrentBook(kesach, "B02");
    PrintNextBook(kesach, "B02");
    
    /*Stack st = new Stack();
    Stack<int> st2 = new Stack<int>();
    Queue q = new Queue();
    Queue<int> q2 = new Queue<int>();*/
    
    /*MyStack ms = new MyStack();
    ms.Push(1);
    ms.Push(9);
    ms.Push(3);
    ms.Push(5);
    System.Console.WriteLine(ms.Peek(2));*/
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
