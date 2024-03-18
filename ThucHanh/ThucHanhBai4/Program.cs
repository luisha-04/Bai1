using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bacluong, ngaycong, phucap;
            do
            {
                Console.Write("Nhap vao bac luong (>0): ");
            }while(!float.TryParse(Console.ReadLine(),out bacluong)|| bacluong <=0);
            do
            {
                Console.Write("Nhap vao ngay cong (>=0): ");
            }while(!float.TryParse(Console.ReadLine(), out ngaycong)|| ngaycong <0);
            do
            {
                Console.Write("Nhap vao phu cap (>=0): ");
            } while (!float.TryParse(Console.ReadLine(), out phucap) || phucap < 0);
            float NCTL;
            if (ngaycong < 25)
            {
                NCTL = ngaycong;
            }
            else
            {
                NCTL = 25 + (ngaycong - 25)*2;
            }
            float TienLinh = bacluong * 149000 * NCTL + phucap;
            Console.WriteLine("Tien linh luong = " +TienLinh);
            Console.ReadLine();
        }
    }
}
