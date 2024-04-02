using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi4_Struct
{
    public class Bai1_Sach
    {

        struct Sach
        {
            public string TieuDe;
            public string TenTacGia;
            public int NamXuatBan;

            public Sach(string _tieude, string _tentacgia, int _namxuatban)
            {
                TieuDe = _tieude;
                TenTacGia = _tentacgia;
                NamXuatBan = _namxuatban;
            }

            public void XuatThongTinSach()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine(" Tiêu Đề: " + TieuDe);
                Console.WriteLine(" Tên Tác Giả: " + TenTacGia);
                Console.WriteLine(" Năm Xuất Bản: " + NamXuatBan);
            }
        }

        static List<Sach> danhSachSach = new List<Sach>();

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choose = 0;
            do
            {
                Menu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        ThemSach();
                        break;
                    case 2:
                        HienThiDanhSachSach();
                        break;
                    case 3:
                        TimKiemSach();
                        break;
                    case 4:
                        Console.WriteLine("Chương trình đã kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Không có lựa chọn này, vui lòng chọn lại.");
                        break;
                }
            } while (choose != 4);
        }

        public static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. Thêm sách mới");
            Console.WriteLine("2. Hiển thị danh sách các sách đã thêm");
            Console.WriteLine("3. Tìm kiếm sách theo tiêu đề");
            Console.WriteLine("4. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");
        }

        public static void ThemSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin về cuốn sách mới:");
            Console.Write("Tiêu đề: ");
            string tieuDe = Console.ReadLine();
            Console.Write("Tên tác giả: ");
            string tenTacGia = Console.ReadLine();
            string input = Console.ReadLine();
            int namXuatBan;
            bool isNumber = int.TryParse(input, out namXuatBan);

            if (isNumber && namXuatBan > 1000 && namXuatBan < 2024)
            {

                Console.WriteLine("Nam Xuat Ban: " + namXuatBan);
                Console.WriteLine("Thêm sách thành công.");
            }
            else
            {
                Console.WriteLine("Nam Xuat Ban Khong Hop le ");
            }



           
        }

        public static void HienThiDanhSachSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("===== Danh Sách Sách =====");
            if (danhSachSach.Count == 0)
            {
                Console.WriteLine("Danh sách sách trống.");
            }
            else
            {
                foreach (var sach in danhSachSach)
                {
                    sach.XuatThongTinSach();
                    Console.WriteLine();
                }
            }
        }

        public static void TimKiemSach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tiêu đề sách cần tìm: ");
            string tieuDeCanTim = Console.ReadLine();

            bool timThay = false;
            foreach (var sach in danhSachSach)
            {
                if (sach.TieuDe.ToLower().Contains(tieuDeCanTim.ToLower()))
                {
                    sach.XuatThongTinSach();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy sách với tiêu đề đã nhập.");
            }
        }
    }
}