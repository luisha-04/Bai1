using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nam, thang;
            do
            {
                Console.Write("Nhap vao thang: ");
            } while (!int.TryParse(Console.ReadLine(), out thang) || thang <1 || thang >12);
            do
            {
                Console.Write("Nhap vao nam: ");
            }while(!int.TryParse(Console.ReadLine(),out nam) || nam <0);
            Boolean b = hamxacnhan(nam,thang);
            if (b == true)
            {
                Console.WriteLine($"Nam {nam} co 366 ngay!");
            }
            else
            {
                Console.WriteLine($"Nam {nam} co 365 ngay!");
            }
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Thang {thang} nam {nam} co 31 ngay! "); 
                    break;
                case 2:

                    if (b == true)
                    {
                        Console.WriteLine($"Thang {thang} nam {nam} co 29 ngay!");
                    }
                    else
                    {
                        Console.WriteLine($"Thang {thang} nam {nam} co 28 ngay!");
                    }
                break;
                default:
                    break;

            }
            Console.ReadLine();

        }
        static Boolean hamxacnhan(int nam, int thang)
        {
            if (nam % 100 == 0)
            {
                int thuong = nam / 100;
                if (thuong % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (nam % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
