using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhBai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao so nguyen duong! = ");
            }while(!int.TryParse(Console.ReadLine(), out n) || n <=0);
            Console.ReadLine();
        }
    }
}
