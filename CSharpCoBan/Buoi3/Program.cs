using Buoi3.Buoi3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class Program
    {
        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }
        static void Main(string[] args)
        {
            try
            {
                UserInput("Đây là một chuỗi rất dài ...");
            }
            catch (DataTooLongExeption e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception otherExeption)
            {
                Console.WriteLine(otherExeption.Message);
            }
        }

    }
}
