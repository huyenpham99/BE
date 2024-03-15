using CSharpCoBan.Buoi1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoBan
{
    internal class Programer
    {
        public void Main(string[] args)
        {
            string input = "123";
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (isNumber)
            {
                Console.WriteLine("The input is a number: " + number);
            }
            else
            {
                Console.WriteLine("The input is not a number");
            }
            for (int i = 1; i <= number; i++)
            {
                if (CheckSoNguyenTo(i))
                {
                    Console.Write("{0}, ", i);
                }

            }
            bool CheckSoNguyenTo(int num)
            {
                int max = num / 2;
                for (int i = 2; i <= max; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
