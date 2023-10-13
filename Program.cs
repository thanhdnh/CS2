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

                Console.ReadKey();
        }
}