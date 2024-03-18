using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so n trong khoang tu 1 den 7: ");
            } while (!int.TryParse(Console.ReadLine(),out n) || n<1 || n>7);
            switch (n)
            {
                case 1:
                    Console.WriteLine("Chu nhat"); 
                    break;
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu 5");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                default:
                    break;

            }
            Console.ReadLine();
        }
    }
}
