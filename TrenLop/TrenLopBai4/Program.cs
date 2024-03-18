using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLopBai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong n: ");
            }while(!int.TryParse(Console.ReadLine(), out n) || n<=0);
            double S = 0;
            //Console.Write("S = ");
            //for (int i = 1; i <= n; i++)
            //{
            //    S += (double)i;
            //    if (i==n)
            //    {
            //        Console.Write($"{i} = ");
            //    }
            //    else
            //    {
            //        Console.Write($"{i}+");
            //    }                               
            //}
            //Console.Write(S);

            //int i = 1;
            //while(i<=n)
            //{
            //    S += i;
            //    i++;
            //}

            int i = 1;
            do
            {
                S+=i;
                i++;
            } while (i <= n);
            Console.WriteLine("Tong S = 1+2+...+n = " + S);
            Console.ReadLine();
        }
    }
}
