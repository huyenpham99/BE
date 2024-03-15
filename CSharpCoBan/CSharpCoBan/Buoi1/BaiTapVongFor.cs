using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoBan.Buoi1
{
    internal class BaiTapVongFor
    {
         public void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Nhap vao so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <=0  || n > 100000){
                Console.WriteLine("Vui long nhap so nguyen lon hon 0");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < n; i++)
            {
                    sum += i;
            }
            Console.WriteLine("Tong cac so nho hon " + n + " la: " + sum);
        }
    }
}
