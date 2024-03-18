using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLopBai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float luong, thuong;
            do
            {
                Console.Write("Nhap vao tien luong (trieu): ");
            }while(!float.TryParse(Console.ReadLine(), out luong) || luong<0);
            do
            {
                Console.Write("Nhap vao tien thuong (trieu): ");
            }while(!float.TryParse(Console.ReadLine(), out thuong) || thuong<0);
            double thunhap = luong + thuong;
            double thue;
            if (thunhap < 9)
            {
                thue = 0;
            }
            else if(thunhap < 15)
            {
                thue = 0.1 * thunhap;
            }
            else if(thunhap < 30)
            {
                thue = 0.15 * thunhap;
            }
            else
            {
                thue = 0.2 * thunhap;
            }
            Console.WriteLine("Tien thue thu nhap (trieu) = " + thue);
            Console.ReadLine();
        }

    }
}
