using System;
class Program
{
        static void Main(string[] args)
        {
                Console.Clear();

                //S1 for
                Console.WriteLine("moi ban nhap so n");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int i = 1;
                for (i = 1; i <= (2 * n + 1); i = i + 2)
                {
                        sum = sum + i;
                }
                Console.WriteLine("for: " + sum);

                //S1 while
                sum = 0;
                i = 1;
                while (i <= 2 * n + 1)
                {
                        sum += i;
                        i = i + 2;
                }
                Console.WriteLine("while: " + sum);

                //S1 do while 
                sum = 0;
                i = 1;
                do
                {
                        sum = sum + i;
                        i += 2;
                }
                while (i <= 2 * n + 1);
                Console.WriteLine("do...while: " + sum);

                //S2 for
                double sum2 = 0;
                for (i = 1; i <= n; i++)
                {
                        sum2 += Math.Pow(i, 2);
                }
                Console.WriteLine("For: S2 = " + sum2);

                //S2 while
                sum = 0;
                i = 1;
                while (i <= n)
                {
                        sum += i * i;
                        i++;
                }
                Console.WriteLine("while S2: " + sum);

                //S2 do while
                sum2 = 0;
                i = 1;
                do
                {
                        sum2 += Math.Pow(i, 2);
                        i = i + 1;
                }
                while (i <= n);
                Console.WriteLine("do...while: S2 = " + sum2);

                //=============Kiem tra so nguyen to
                bool nt = true;
                if(n==2)
                        nt = true;
                else
                        for(i=2; i<=Math.Sqrt(n); i++)
                                if(n%i==0){
                                        nt = false;
                                        break;
                                }else
                                        nt = nt && true;
                if(nt)
                        System.Console.WriteLine("{0} la NT", n);
                else
                        System.Console.WriteLine("{0} khong la NT", n);
                
                //=======Tong S=9+99+...+999...9
                //C1. Cong xau
                string s = "";
                ulong S1 = 0;
                for(i=1; i<=n; i++){
                        s+="9";
                        S1+=ulong.Parse(s);
                        //System.Console.WriteLine(s);
                }
                System.Console.WriteLine(S1);

                //C2. 999=10^3-1
                //C3. 999=9*10^2+9*10^1+9*10^0
                //C4. Dung log
                
                Console.ReadKey();
        }
}