using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
namespace Parallel_For_e
{
    class Program
    {
        static void Main(string[] args)
        {
            //e^x sayısına taylor serisi ile yaklaşma
            long terim = 50000;   //Hesaplanacak terim adeti
            double sum = 0;
            double x = 1;        //x değeri
            Parallel.For(0, terim, count =>
            {
                double factorial = 1;
                long i = count;
                while (i >= 1)
                {
                    factorial *= i;
                    i = i - 1;
                }
                double yedek = Math.Pow(x, count) / factorial; //i. Terimi hesaplama
                sum += yedek;
            });
            Console.WriteLine("Result="+sum); 
        }
    }
}
