using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai tap 2:
            float length, width;

            // Nhập chiều dài
            do
            {
                Console.Write("Nhap chieu dai (so thuc duong): ");
            } while (!float.TryParse(Console.ReadLine(), out length) || length <= 0);

            // Nhập chiều rộng
            do
            {
                Console.Write("Nhap chieu rong (so thuc duong): ");
            } while (!float.TryParse(Console.ReadLine(), out width) || width <= 0);
            float cv = 2 * (length + width);
            float dt = length * width;
            Console.WriteLine("Chu vi cua hinh chu nhat = " + cv);
            Console.WriteLine("Dien tich cua hinh chu nhat = " + dt);
            Console.ReadLine();
        }
    }
}
