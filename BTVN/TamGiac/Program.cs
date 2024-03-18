using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            do
            {
                Console.Write("Nhap vao mot canh a cua tam giac: ");

            }while(!float.TryParse(Console.ReadLine(), out a) || a<=0);
            do
            {
                Console.Write("Nhap vao mot canh b cua tam giac: ");

            } while (!float.TryParse(Console.ReadLine(), out b) || b <= 0);
            do
            {
                Console.Write("Nhap vao mot canh c cua tam giac: ");

            } while (!float.TryParse(Console.ReadLine(), out c) || c <= 0);
            float cv = a + b + c;
            float p = cv / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Dien tich tam giac la: " + S);
            Console.WriteLine("Chu vi tam giac la: " + cv);
            Console.ReadLine();     
        }
    }
}
