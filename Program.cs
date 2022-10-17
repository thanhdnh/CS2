using System.Collections;
public class Program{
    static void InitArray1D(out Array arr, int len, int low){
        arr = Array.CreateInstance(typeof(int), new int[1]{len}, new int[1]{low});
    }
    static void GenerateArray1D(Array arr){
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(r.Next(1, 99), i);
    }
    static int SumArray1D(Array arr){
        int sum = 0;
        foreach(int v in arr)
            sum += v;
        return sum;
    }
    static void InitArray2D(out Array arr, int[] len, int[] low){
        arr = Array.CreateInstance(typeof(int), len, low);
    }
    static void GenerateArray2D(Array arr){
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                arr.SetValue(r.Next(1, 99), i, j);
    }
    static void PrintArray2D(Array arr){
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++){
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                System.Console.Write("{0, 5}", arr.GetValue(i, j));
            System.Console.WriteLine();
        }
    }
    public static void Main(){
        Console.Clear();

        int[] len = {3, 4};
        int[] low = {1, 1};
        Array arr2;
        InitArray2D(out arr2, len, low); GenerateArray2D(arr2); PrintArray2D(arr2);

        /*Array arr;
        InitArray1D(out arr, 5, 0);
        GenerateArray1D(arr);
        foreach(int v in arr)
            System.Console.Write(v + " ");
        System.Console.WriteLine("\nTong la: " + SumArray1D(arr));*/

        /*Array arr = Array.CreateInstance(typeof(int), 5);
        arr.SetValue(99, 1);
        System.Console.WriteLine(arr.GetValue(1));
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(r.Next(1, 99), i);
        foreach(int v in arr)
            System.Console.Write(v + " ");
        System.Console.WriteLine();*/

        Console.ReadLine();
    }
}
