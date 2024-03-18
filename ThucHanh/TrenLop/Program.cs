using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                Console.Write("Nhap vao so thuc a khac 0: ");
            }while (!double.TryParse(Console.ReadLine(), out a) || a ==0);
            do
            {
                Console.Write("Nhap vao so thuc b: ");
            }while(!double.TryParse(Console.ReadLine(),out b));
            do
            {
                Console.Write("Nhap vao so thuc c: ");
            } while (!double.TryParse(Console.ReadLine(),out c));
            Console.WriteLine($"Chuong trinh giai phuong trinh bac hai {a}x^2 + {b}x + {c} = 0");
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem! ");
            }
            else if(delta == 0)
            {
                double x = -b/(2*a);
                Console.WriteLine("Phuong trinh co nghiem kep " + x);
            }
            else
            {           
                double x1sau = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 3);
                double x2sau = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 3);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                Console.WriteLine("x1 = " + x1sau);
                Console.WriteLine("x2 = " + x2sau);
            }
            Console.ReadLine();
        }
    }
}
