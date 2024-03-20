using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Buoi2.Baitapbuoi2
{
    internal class Baitap
    {
        // Bài 1 : In dãy số nguyên tố nhỏ hơn số được nhập vào từ bàn phím
        public void Bai1_SoNguyenTo()
        {
            Console.WriteLine("Please input a number: ");
            string input = Console.ReadLine();
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
        //Bài 2 : Viết chương trình c# Nhập vào 1 chuỗi bất kỳ sau đó hãy đảo ngược chuoi đó
        public void Bai2_DaoNguocChuoi()
        {
            string chuoi, chuoi1 = "";
            int i, l;
            Console.WriteLine("Nhap mot chuoi: ");
            chuoi = Console.ReadLine();

            l = chuoi.Length - 1;
            for (i = l; i >= 0; i--)
            {
                chuoi1 = chuoi1 + chuoi[i];
            }
            Console.WriteLine("Chuoi dao nguoc cua chuoi ban dau la: {0}", chuoi1);
            Console.Write("\n");
            Console.ReadKey();
        }
        //Bài 3: Đếm số lần xuất hiện của một ký tự trong chuỗi
        public void Bai3_DemKyTu()
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string chuoi = Console.ReadLine();
            chuoi = chuoi.Replace(" ", string.Empty);
            while (chuoi.Length > 0)
            {
                Console.Write(chuoi[0] + ":");
                int count = 0;
                for(int i =0; i<chuoi.Length; i++)
                {
                    if (chuoi[0] == chuoi[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                chuoi = chuoi.Replace(chuoi[0].ToString(), string.Empty);
            }
        }
        //Bài 4 sử dụng do-while để Tính giai thừa của một số
        public void Bai4_TinhGiaiThua()
        {
            Console.WriteLine("Please input a number: ");
            string input = Console.ReadLine();
            int number;
            int giaithua = 1;
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
                giaithua *= i;
            }
            Console.WriteLine("Giai thua cua so: "+ $"{number}! = {giaithua}");
        }
        //Sử dụng do-while để  Đoán số ngẫu nhiên
        //( nhập vào bàn phím 1 số bất kỳ và so sánh với số được sinh ra từ Class Random trong c#)
        public void SinhSoNgauNhien()
        {
            Console.WriteLine("Sinh So ngau nhien:");
            Random random = new Random();
        }

    }
}
        

   


