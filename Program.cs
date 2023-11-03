using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static bool KTDXMang(int[] a){
        for(int i=0; i<a.Length/2; i++){
            if(a[i]!=a[a.Length-i-1])
                return false;
        }
        return true;
    }
    static bool KTDXMang2(int[] a){
        int[] b = new int[a.Length/2+1];
        for(int i=0; i<=a.Length/2; i++)
            b[i] = a[i]-a[a.Length-i-1];
        for(int i=0; i<b.Length; i++)
            if(b[i]!=0)
                return false;
        return true;
    }
    static int TongMang(int[] a){
        int T = 0;
        for(int i=0; i<a.Length; i++)
            if(a[i]%2!=0)
                T += a[i];
        return T;
    }
    static int TongMang2(int[] a){
        int T = 0;
        foreach(int v in a)
            if(v%2!=0)
                T += v;
        return T;
    }
    static bool Exist(int x, int[] arr){
        for(int i=0; i<arr.Length; i++)
            if(arr[i]==x)
                return true;
        return false;
    }
    static int[] FilterArr(int[] a){
        int[] b = new int[a.Length];
        for(int i=0; i<b.Length; i++)
            b[i] = int.MaxValue;
        int index = 0;
        for(int i=0; i<a.Length; i++)
            if(!Exist(a[i], b))
                b[index++] = a[i];
        int[] result = new int[index];
        index = 0;
        foreach(int v in b)
            if(v!=int.MaxValue)
                result[index++] = v;
        return result;
    }
    static void Main(string[] args){
        Console.Clear();
        int[] a = new int[]{3, 4, 3, 9, 3, 4, 6};
        int [] c = FilterArr(a);
        foreach(int v in c)
            Console.Write(v+" ");
        //Console.WriteLine(KTDXMang2(a));
        
        Console.ReadLine();
    }
}