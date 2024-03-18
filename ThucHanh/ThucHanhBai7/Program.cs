using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Nhập số nguyên dương n
            do
            {
                Console.Write("Nhap so nguyen n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            // Kiểm tra số nguyên tố
            bool isPrime = IsPrime(n);

            // In kết quả
            if (isPrime)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }

            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            // Các trường hợp đặc biệt
            if (n <= 2)
            {
                return false;
            }
            if (n == 3)
            {
                return true;
            }

            // Kiểm tra từ 2 đến căn bậc hai của n
            int sqrt = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
            Console.ReadLine();
        }
    }
}
