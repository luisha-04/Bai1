using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Bai tap 1: 
            Console.Write("Nhap vao so nguyen n= ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"a) {n} la so chan! ");
            }
            else
            {
                Console.WriteLine($"a) {n} la so le");
            }
            if (n < 0)
            {
                Console.WriteLine($"b) {n} la so am! ");
            }
            else
            {
                Console.WriteLine($"b) {n} la so khong am! ");
            }
            Console.ReadLine();

        }
    }
}
