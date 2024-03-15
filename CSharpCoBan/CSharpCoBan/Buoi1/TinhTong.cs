using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoBan.Buoi1
{
    internal class TinhTong
    {
         public void Sum(string[] args)
           {
               int a, b;
               Console.WriteLine("Nhap vao so a: ");
               a = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Nhap vao so b: ");
               b = Convert.ToInt32(Console.ReadLine());
               int sum = a + b;
               Console.WriteLine("Tong hai so a + b = " + sum);
           }

    }
}
