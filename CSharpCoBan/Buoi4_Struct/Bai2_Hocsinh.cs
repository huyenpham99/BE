using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Buoi4_Struct
{
    class Bai2_HocSinh
    {
        struct HocSinh
        {
            public string Ten;
            public int Tuoi;
            public double DiemTrungBinh;

            public HocSinh(string ten, int tuoi, double diemTrungBinh)
            {
                Ten = ten;
                Tuoi = tuoi;
                DiemTrungBinh = diemTrungBinh;
            }

            public void XuatThongTinHocSinh()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Tên: " + Ten);
                Console.WriteLine("Tuổi: " + Tuoi);
                Console.WriteLine("Điểm Trung Bình: " + DiemTrungBinh);
            }
        }

        static List<HocSinh> danhSachHocSinh = new List<HocSinh>();

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
                        ThemHocSinh();
                        break;
                    case 2:
                        HienThiDanhSachHocSinh();
                        break;
                    case 3:
                        TimKiemHocSinh();
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
            Console.WriteLine("1. Thêm học sinh mới");
            Console.WriteLine("2. Hiển thị danh sách các học sinh đã thêm");
            Console.WriteLine("3. Tìm kiếm học sinh theo tên");
            Console.WriteLine("4. Thoát chương trình");
            Console.Write("Nhập lựa chọn của bạn: ");
        }

        public static void ThemHocSinh()

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập thông tin về học sinh mới:");
            Console.Write("Tên: ");
            string ten = Console.ReadLine();
            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Điểm trung bình: ");
            double diemTrungBinh = double.Parse(Console.ReadLine());

            HocSinh hocSinhMoi = new HocSinh(ten, tuoi, diemTrungBinh);
            danhSachHocSinh.Add(hocSinhMoi);

            Console.WriteLine("Thêm học sinh thành công.");
        }

        public static void HienThiDanhSachHocSinh()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("===== Danh Sách Học Sinh =====");
            if (danhSachHocSinh.Count == 0)
            {
                Console.WriteLine("Danh sách học sinh trống.");
            }
            else
            {
                foreach (var hocSinh in danhSachHocSinh)
                {
                    hocSinh.XuatThongTinHocSinh();
                    Console.WriteLine();
                }
            }
        }

        public static void TimKiemHocSinh()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập tên học sinh cần tìm: ");
            string tenCanTim = Console.ReadLine();

            bool timThay = false;
            foreach (var hocSinh in danhSachHocSinh)
            {
                if (hocSinh.Ten.ToLower().Contains(tenCanTim.ToLower()))
                {
                    hocSinh.XuatThongTinHocSinh();
                    timThay = true;
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy học sinh với tên đã nhập.");
            }
        }
    }
}