using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLopBai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang, nam;
            do
            {
                Console.Write("Nhap vao thang: ");
            } while (!int.TryParse(Console.ReadLine(), out thang) || thang < 1 || thang > 12);
            do
            {
                Console.Write("Nhap vao nam: ");
            } while (!int.TryParse(Console.ReadLine(), out nam) || nam < 0);
            int ngay;
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
                    if (nam % 100 == 0)
                    {
                        int thuong = nam / 100;
                        if(thuong % 4 == 0)
                        {
                            Console.WriteLine($"Thang 2 nam {nam} co 29 ngay! ");
                        }
                        else
                        {
                            Console.WriteLine($"Thang 2 nam {nam} co 28 ngay! ");
                        }
                       
                    }
                    else if(nam % 4==0)
                    {
                        Console.WriteLine($"Thang 2 nam {nam} co 29 ngay! ");
                    }
                    else
                    {
                        Console.WriteLine($"Thang 2 nam {nam} co 28 ngay! ");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Thang {thang} nam {nam} co 30 ngay! ");
                    break;
                default:
                    break;




            }
            Console.ReadLine();

        }
    }
}
