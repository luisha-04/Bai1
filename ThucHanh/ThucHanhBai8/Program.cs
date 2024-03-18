using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong! = ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            Console.WriteLine($"Cac so tu 1 den {n} bo qua cac so chia het cho 5! :");
            for (int i = 0; i < n; i++)
            {
                if (i % 5 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
