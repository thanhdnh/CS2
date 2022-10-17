using System.Collections;
public class Program{
    public static void Main(){
        Console.Clear();

        Array arr = Array.CreateInstance(typeof(int), 5);
        arr.SetValue(99, 1);
        System.Console.WriteLine(arr.GetValue(1));

        Console.ReadLine();
    }
}
