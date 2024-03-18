using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten: ");
            string hoten = Console.ReadLine();

            float diemthi;
            do
            {
                Console.Write("Nhap diem thi cuoi ky (0-10): ");
            } while (!float.TryParse(Console.ReadLine(), out diemthi) || diemthi < 0 || diemthi > 10);
            string xeploai;
            if (diemthi >= 8)
            {
                xeploai = "Gioi";
            }
            else if (diemthi >= 6.5)
            {
                xeploai = "Kha";
            }
            else if (diemthi >= 5)
            {
                xeploai = "Trung binh";
            }
            else
            {
                xeploai = "Yeu";
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ho ten hoc sinh: " + hoten.ToUpper());
            Console.WriteLine("Diem thi: " + diemthi);
            Console.WriteLine("Xep loai: " + xeploai);
            Console.ReadLine();
        }
    }
}
