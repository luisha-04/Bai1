using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1BTTH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            // Nhập số nguyên m
            do
            {
                Console.Write("Nhap so nguyen m: ");
            } while (!int.TryParse(Console.ReadLine(), out m));

            // Nhập số nguyên n khác 0
            do
            {
                Console.Write("Nhap so nguyen n (khac 0): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n == 0);

            // Tính ước chung lớn nhất của m và n
            int gcd = GCD(m, n);

            // Rút gọn phân số
            int tusau = m / gcd;
            int mausau = n / gcd;

            // In kết quả
            Console.WriteLine($"Phan so rut gon cua {m}/{n} la: {tusau}/{mausau}");

            Console.ReadLine();
        }

        static int GCD(int m, int n)
        {
            // Thuật toán Euclidean để tính ước chung lớn nhất
            int temp;
            while (n != 0)
            {
                temp = n;
                n = m % n;
                m = temp;
            }
            return m;
        }
    }
}
