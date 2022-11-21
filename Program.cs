using System.Collections;
public class Program
{
  static void Main()
  {
    Console.Clear();

    Account acc1 = new Account("abc", "abc@xyz.com", 20, "Hello!");
    Account acc2 = new Account("def", "def@xyz.com", 22, "Hi!");
    Account acc3 = new Account("ijk", "ijk@xyz.com", 21, "Hey!");
    //System.Console.WriteLine(acc2);
    /*AccountDict acd = new AccountDict();
    acd.Add(acc1.Email, acc1);
    acd.Add(acc2.Email, acc2);
    acd.Add(acc3.Email, acc3);
    IDictionaryEnumerator e = acd.GetEnumerator();
    while(e.MoveNext())
      System.Console.WriteLine("{0}=>{1}", e.Key, e.Value);*/

    Dictionary<string, Account> dicnet = new Dictionary<string, Account>();
    dicnet.Add(acc1.Email, acc1);
    dicnet.Add(acc2.Email, acc2);
    dicnet.Add(acc3.Email, acc3);
    foreach(KeyValuePair<string, Account> kvp in dicnet)
      System.Console.WriteLine("{0}=>{1}", kvp.Key, kvp.Value);
    /*IDictionaryEnumerator e = dicnet.GetEnumerator();
    while(e.MoveNext())
      System.Console.WriteLine("{0}=>{1}", e.Key, e.Value);*/

    Console.ReadLine();
  }
}