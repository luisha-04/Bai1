using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai tap 3a:
            //float a;
            //do
            //{
            //    Console.Write("Nhap vao so a = ");
            //}while(!float.TryParse(Console.ReadLine(),out a) || a == 0);

            //Console.Write("Nhap vao so b = ");
            //float b = float.Parse(Console.ReadLine());

            //Console.WriteLine($"a) Chuong trinh giai phuong trinh bac nhat {a}x + {b} = 0");
            //float x = -b / a;
            //Console.WriteLine($"\n Nghiem x = {x}");

            //Console.ReadLine() ;

            //Bai tap 3b:
            double a, b, c;

            // Nhập hệ số a, b, c
            Console.Write("Nhap he so a: ");
            while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
            {
                Console.Write("He so a phai la so thuc khac 0. Nhap lai: ");
            }

            Console.Write("Nhap he so b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("He so b phai la so thuc. Nhap lai: ");
            }

            Console.Write("Nhap he so c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("He so c phai la so thuc. Nhap lai: ");
            }
            Console.WriteLine($"b) Chuong trinh giai phuong trinh bac hai {a}x^2 + {b}x + {c} = 0");
            // Tính delta
            double delta = b * b - 4 * a * c;

            // Xử lý các trường hợp
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            Console.ReadLine();

        }
    }
}
