using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int myInt = 2000; 
            string myName = "My Name is Huyen";
            Console.WriteLine(myName + "test");
          
            var myVariable = 100;
            var myVariable1 = "String";
            if(myInt > 100 && myInt < 1000)
            {
                Console.WriteLine("OKe");
            }

            int Input = 0;
            Console.WriteLine("Nhao so:");
            Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So ban vua nhap la:" + Input);
            Console.ReadKey();

        }
    }
}
