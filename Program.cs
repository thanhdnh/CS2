﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Bai 4. Kiem tra nam nhuan
        /*Console.WriteLine("Nhập vào 1 số: ");
        int nam = int.Parse(Console.ReadLine());
        if (nam % 4 == 0 && nam % 100 != 0 )
        {
          Console.WriteLine("Nam do la nam nhuan");
        }
         else
        {
          Console.WriteLine("Nam do khong phai la nam nhuan");
        }*/

        //Bai 8. Kiem tra diem thuoc goc phan tu
        /*float x, y;
        Console.WriteLine("Hay nhap vao hoanh do x: ");
        x = float.Parse(Console.ReadLine());
        Console.WriteLine("Hay nhap vao tung do y: ");
        y = float.Parse(Console.ReadLine());
        if ((x == 0) && (y == 0))
                Console.WriteLine("Diem co toa do ({0}, {1}) nam o goc toa do O", x,y);
        else if (x == 0)
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren truc tung", x, y);
        else if (y == 0)
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren truc hoanh", x, y);
        else if ((x > 0) && (y > 0))
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren phan tu thu I", x, y);
        else if ((x < 0) && (y >0))
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren phan tu thu II", x, y);
        else if ((x < 0) && (y < 0))
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren phan tu thu III", x, y);
        else if ((x > 0) && (y < 0))
                Console.WriteLine("Diem co toa do ({0}, {1}) nam tren phan tu thu IV", x, y);
        */

        //Bai 9. Tim so lon nhat trong 3 so
        /*Console.WriteLine("Nhap 3 so: ");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        if (a >= b && a >= c)
                Console.WriteLine("So lon nhat la: {0}", a);
        else
        {
                if (b>=c)
                        Console.WriteLine("So lon nhat la: {0}", b);
                else
                        Console.WriteLine("So lon nhat la: {0}", c);
        }*/

        //Bai 12. Kiem tra loai tam giac
        Console.Write("Nhap vao canh a:");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhap vao canh b:");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Nhap vao canh c:");
        float c =  float.Parse(Console.ReadLine());
        if(a<=0 || b<=0 || c<=0)
            Console.WriteLine("Khong phai la 3 canh TG");
        else if(a+b>c && b+c>a && c+a>b){
            if(a==b && b==c)
                Console.WriteLine("Tam giac deu");
            else if(a==b || b==c || a==c){
                if(a*a+b*b==c*c || b*b+c*c==a*a || c*c+a*a==b*b)
                    Console.WriteLine("Tam giac vuong can");
                else
                    Console.WriteLine("Tam giac can");
            }else{
                if(a*a+b*b==c*c || b*b+c*c==a*a || c*c+a*a==b*b)
                    Console.WriteLine("Tam giac vuong");
                else
                    Console.WriteLine("Tam giac thuong");
            }
        }else
            System.Console.WriteLine("Khong phai la 3 canh TG");
        Console.ReadKey();
        
    }
}