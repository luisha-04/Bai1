using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CanBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, epsilon;

            // Nhập số a
            do
            {
                Console.Write("Nhap so a (a > 0): ");
            } while (!double.TryParse(Console.ReadLine(), out a) || a <= 0);

            // Nhập độ chính xác epsilon
            do
            {
                Console.Write("Nhap do chinh xac epsilon (epsilon > 0): ");
            } while (!double.TryParse(Console.ReadLine(), out epsilon) || epsilon <= 0);

            double x = SquareRoot(a, epsilon);
            Console.WriteLine($"Can bac 2 cua {a} la: {x}");

            Console.ReadLine();
        }

        static double SquareRoot(double a, double epsilon)
        {
            double x0 = 1; // Giá trị ban đầu của x
            double x1 = (a / x0 + x0) / 2; // Tính giá trị mới của x
            int dem = 0;
            Console.Write("Buoc " + dem + ": ");
            Console.WriteLine("x0= " + x0 + ", x1= " + x1);
            while (Math.Abs(x1 - x0) >= epsilon)
            {
                dem++;
                x0 = x1;
                x1 = (a / x0 + x0) / 2;
                Console.Write("Buoc " + dem +": ");
                Console.WriteLine("x0= "+x0 + ", x1= " +x1);
            }

            return x1;
        }
    }
}
