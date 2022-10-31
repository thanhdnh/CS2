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
  static int SenSearch(int[] A, int value)
  {
    int a = A[A.Length - 1];
    A[A.Length - 1] = value;
    int i = 0;
    while (A[i] != value)
      i++;
    A[A.Length - 1] = a;
    if (i < A.Length - 1 || A[A.Length] == value)
      return i;
    return -1;

  }
  static int BinSearch (int[] arr, int value) {
    int l = 0, r = arr.Length - 1;
    while (l <= r) {
      int m = (l + r) / 2;
      if (arr[m] == value) return m;
      else if (arr[m] < value) {
        l = m + 1;
      }
      else if (arr[m] > value) {
        r = m - 1;
      }
    }
    return -1;
  }
  public static void Main()
  {
    Console.Clear();

    int[] arr = new int[6] { 1, 8, 4, 5, 3, 5 };
    int value = 5;
    System.Console.WriteLine("Vi tri cua PT {0} la {1}", value, SenSearch(arr, value));
    //Console.WriteLine("Vi tri cua PT {0} la {1}", value, RecuSearch(arr, 0, value));
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
    /*int[] A = new int[6] {1, 3, 4, 6, 8, 11};
    int T = int.Parse(Console.ReadLine());
    Console.WriteLine("index {0}", BinSearch(A, T));*/

    //need to check more
    /*int max = arr[0];
    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] > max) max = arr[i];
    }
    int[] index = new int[max + 1];
    for (int i = 0; i < arr.Length - 1; i++) {
      index[arr[i]] = i;
    }
    int[] B = new int[6];
    Array.Copy(arr, B, 6);
    Array.Sort(B);
    int T = int.Parse(Console.ReadLine());
    int j = BinSearch(B, T);
    Console.WriteLine("index {0}", index[B[j]]);*/

    Console.ReadLine();
  }
}
