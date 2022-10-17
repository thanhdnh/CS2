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
    public static void Main(){
        Console.Clear();

        Array arr;
        InitArray1D(out arr, 5, 0);
        GenerateArray1D(arr);
        foreach(int v in arr)
            System.Console.Write(v + " ");
        System.Console.WriteLine("\nTong la: " + SumArray1D(arr));

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
