using System.Collections;
public class Program
{
  static int SeqSearch(int[] arr, int value)
  {
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        return i;
    return -1;
  }
  static int SeqLastSearch(int[] arr, int value)
  {
    for (int i = arr.Length - 1; i >= 0; i--)
      if (arr[i] == value)
        return i;
    return -1;
  }
  static List<int> SeqMultiSearch(int[] arr, int value)
  {
    List<int> result = new List<int>();
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        result.Add(i);
    return result;
  }

  static int RecuSearch(int[] arr, int from, int value)
  {
    if (arr.Length == 0 || from >= arr.Length)
      return -1;
    else
      if (arr[from] == value)
      return from;
    else
      return RecuSearch(arr, from + 1, value);
  }
  public static void Main()
  {
    Console.Clear();

    int[] arr = new int[6] { 1, 8, 4, 5, 3, 5 };
    int value = 5;
    Console.WriteLine("Vi tri cua PT {0} la {1}", value, RecuSearch(arr, 0, value));
    //Console.WriteLine("Vi tri cua PT {0} la {1}", value, SeqSearch(arr, value));
    /*List<int> result = SeqMultiSearch(arr, value);
    if (result.Count > 0)
    {
      System.Console.Write("PT {0} xuat hien o: ", value);
      foreach (int v in result)
        System.Console.Write(v + " ");
    }
    else
      System.Console.WriteLine("PT {0} khong ton tai trong mang!");
    */

    Console.ReadLine();
  }
}
