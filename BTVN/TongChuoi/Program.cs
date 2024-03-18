using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            int sa = tinha(n);
            Console.WriteLine(sa);
            
            double Sb = tinhb(n);
            double sbsau = Math.Round(Sb, 2);
            Console.Write(sbsau);
            Console.ReadLine();
        }
        static int tinha(int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write("a) S= ");
                }
                else if (i != n)
                {
                    Console.Write(i + "+");
                }
                else
                {
                    Console.Write(i + "= ");
                }
                sum += i;
            }
            return sum;        
        }
        static double tinhb(int n)
        {
            double sumb = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write("b) S= ");
                }
                else if (i != n)
                {
                    Console.Write(1 + "/" + i + "+");
                }
                else
                {
                    Console.Write(1 + "/" + i + "= ");
                }
                sumb += 1.0 / i;
            }
            return sumb;
        }
    }
}
