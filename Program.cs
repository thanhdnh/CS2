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
    static void GenerateList<T>(List<T> list){
        Random r = new Random();
        for(int i=0; i<10; i++)
            list.Add((dynamic)r.Next(1, 99));
    }
    static T SumList<T>(List<T> list){
        T sum = list[0];
        for(int i=1; i<list.Count; i++)
            sum += (dynamic)list[i];
        return sum;
    }
    static void PrintList<T>(List<T> list){
        foreach(T v in list)
            System.Console.Write(v + " ");
    }
    static void GenerateList2D<T>(List<List<T>> list, int len1, int len2){
        Random r = new Random();
        for(int i=0; i<len1; i++){
            List<T> temp = new List<T>();
            for(int j=0; j<len2; j++)
                temp.Add((dynamic)r.Next(1, 99));
            list.Add(temp);
        }
    }
    static void PrintList2D<T>(List<List<T>> list){
        for(int i=0; i<list.Count; i++){
            for(int j=0; j<list[i].Count; j++)
                System.Console.Write(list[i][j] + " ");
            System.Console.WriteLine();
        }
    }
    static void GenerateArrayList1D(ArrayList arl){
        Random r = new Random();
        for(int i=0; i<10; i++)
            arl.Add(i);
    }
    static int SumArrayList(ArrayList arl){
        int sum = 0;
        foreach(int v in arl)
            sum += v;
        /*for(int i=0; i<arl.Count; i++)
            sum += (int)arl[i];*/
        return sum;
    }
    class Student{
        public string id;
        public string hoten;
        public float dtb;
    }
    public static void Main(){
        Console.Clear();

        Student st1 = new Student();
        st1.id = "SV01"; st1.hoten = "Nguyen A"; st1.dtb = 5.6f;
        Student st2 = new Student();
        st2.id = "SV02"; st2.hoten = "Nguyen B"; st2.dtb = 7.5f;
        List<Student> list = new List<Student>();
        list.Add(st1); list.Add(st2);
        System.Console.WriteLine($"ID: {list[1].id}, Ten: {list[1].hoten}, DTB: {list[1].dtb}");

        /*ArrayList arl2 = new ArrayList();
        arl2.Add(2); arl2.Add(3.14f); arl2.Add("Hello");
        object x = arl2[(new Random()).Next(0, 3)];
        System.Console.WriteLine("{0}: {1}", x, x.GetType());*/

        /*ArrayList arl = new ArrayList();
        GenerateArrayList1D(arl);
        System.Console.WriteLine("Tong ArrayList: " + SumArrayList(arl));*/

        /*List<List<int>> list = new List<List<int>>();
        GenerateList2D<int>(list, 4, 3); PrintList2D<int>(list);*/

        /*List<int> list = new List<int>();
        GenerateList<int>(list);
        System.Console.WriteLine("Tong list: " + SumList<int>(list));*/

        /*int[] len = {3, 4};
        int[] low = {1, 1};
        Array arr2;
        InitArray2D(out arr2, len, low); GenerateArray2D(arr2); PrintArray2D(arr2);
        */
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
