using System;
class Program
{
        //Khai báo hàm
        static double TinhTong(double a, double b){
            double result = a + b;
            return result;
        }
        static void InHoTen(string ho, string ten){
            Console.WriteLine("Sinh viên [{0}] [{1}].", ho, ten);
        }
        static double TinhDTTG(double a, double b, double c){
            double p = (a+b+c)/2;
            double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return area;
        }
        static void GiaiPTBac1(double a, double b){//ax+b=0
            if(a==0)
                if(b==0)
                    System.Console.WriteLine("VSN");
                else
                    System.Console.WriteLine("VN");
            else{
                double x = -b/a;
                System.Console.WriteLine("Nghiem: {0}", x);
            }
        }
        //S=1/2+1/3+...+1/n , n>=1
        static double TinhTongN(int n){
            double result = 0;
            for(int i=1; i<=n; i++)
                result += 1/(double)i;//result += 1.0/i;
            return result;
        }
        static void NoSwap(int a, int b){
            int c = a;
            a = b;
            b = c;
        }
        static void SwapRef(ref int a, ref int b){
            int c = a;
            a = b;
            b = c;
        }
        static void SwapOut(out int a, out int b){
            a = 1; b = 2;
            int c = a;
            a = b;
            b = c;
        }
        static void Sort(ref int a, ref int b, ref int c){
            int min = Math.Min(Math.Min(a, b), c);
            int max = Math.Max(Math.Max(a, b), c);
            int r = (a+b+c)-min-max;
            a = min;
            b = r;
            c = max;
        }
        static void TinhSC(float R, out float S, 
                                        out float C){
            S = (float)Math.PI*R*R;
            C = 2*(float)Math.PI*R;
        }
        static void Main(string[] args){
            Console.Clear();
            float R = 2.3f;
            float SS, CC;
            TinhSC(R, out SS, out CC);
            Console.WriteLine($"Voi R={R}, thi S={SS}, C={CC}");

            /*int a = 7, b = 9, c = 2;
            Sort(ref a, ref b, ref c);
            Console.WriteLine("a={0}, b={1}, c={2}",a,b,c);*/

            //int a = 5, b = 6;
            //SwapRef(ref a, ref b);
            //SwapOut(out a, out b);
            //System.Console.WriteLine(a+", "+b);
            /*double a = 3.4, b = 5.6;
            GiaiPTBac1(a, b);

            int n = 10;
            System.Console.WriteLine("Tong{0}: {1}", n, TinhTongN(n));
            */
            /*Console.WriteLine("Nhap 3 canh TG: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dien tich TG: {TinhDTTG(a, b, c)}");*/

            /*System.Console.WriteLine("Nhap x = , y = ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}",x,y,TinhTong(x, y));

            System.Console.WriteLine("Nhập họ: ");
            string h = Console.ReadLine();
            System.Console.WriteLine("Nhập tên: ");
            string t = Console.ReadLine();
            InHoTen(h, t);*/

            Console.ReadLine();
        }
}