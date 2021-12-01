using System;
using System.Collections.Generic;

namespace KiemTraQLNV
{
    class Program
    {
        static void Main(string[] args)
        {
            static void menu()
            {
                Console.WriteLine("Ho Ten SV: Tra Lam Cao");
                Console.WriteLine("Lop: CTT14CD3A\n");

                Console.WriteLine("\tQuan Ly Nhan Su");
                Console.WriteLine("1.Them nhan vien (nhap ae)");
                Console.WriteLine("2.Them khach hang (nhap ac)");
                Console.WriteLine("3.Hien thi thong tin nhan vien (nhap dae)");
                Console.WriteLine("4.Hien thi thong tin khach hang (nhap dac)");
                Console.WriteLine("5.Thong ke khach hang (Nhap cs)");
                Console.WriteLine("6.Thoat chuong trinh (Nhap exit)\n");            
            }
            List<Nhanvien> DSNV = new List<Nhanvien>();
            List<Khachhang> DSKH = new List<Khachhang>();

            Nhanvien nv1 = new Nhanvien("NV01", "le van my", "Nu", "1/07/2002", "Cao Dang");
            Nhanvien nv2 = new Nhanvien("NV02", "Nguyen duc tho", "Nam", "09/07/2002", "Dai Hoc");
            Khachhang kh1 = new Khachhang("KH01", "tran van hoa", "Nam", "22/02/2002", "khach hang vip");
            Khachhang kh2 = new Khachhang("KH02", "nguyen huu duc", "Nam", "19/03/2002", "ThanhVien");
            DSNV.Add(nv1);
            DSNV.Add(nv2);
            DSKH.Add(kh1);
            DSKH.Add(kh2);
            try
            {
                while (true)
                {
                    string selection;
                    Console.Clear();
                    menu();
                    Console.Write("Nhap lua chon tu ban phim: ");
                    selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "ae":
                            addEmployee(DSNV);
                            break;
                        case "ac":
                            addCustomer(DSKH);
                            break;
                        case "dae":
                            dataEmployee(DSNV);
                            Console.ReadKey();
                            break;
                        case "dac":
                            dataCustomer(DSKH);
                            Console.ReadKey();
                            break;
                        case "cs":
                            thongke(DSKH);
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Nhap khong hop le! Vui long nhap lai");
                            Console.ReadKey();
                            continue;
                    }

                }
            }

            catch (Exception EXC)
            {
                Console.WriteLine(EXC);
            }
        }

        static void addEmployee(List<Nhanvien> DSNV)
        {
            string MANV = "NV0" + Convert.ToString(DSNV.Count + 1);
            Console.Write("Nhap Ho ten nhan vien: ");
            string TEN = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string GT = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            string NS = Console.ReadLine();
            Console.Write("Nhap bang cap: ");
            string BC = Console.ReadLine();
            Nhanvien NV = new Nhanvien(MANV, TEN, GT, NS, BC);
            DSNV.Add(NV);
        }
        static void addCustomer(List<Khachhang> DSKH)
        {
            string MAKH = "KH0" + Convert.ToString(DSKH.Count + 1);
            Console.Write("Nhap Ho ten nhan vien: ");
            string TEN = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string GT = Console.ReadLine();
            Console.Write("Nhap ngay thang nam sinh: ");
            string NS = Console.ReadLine();
            Khachhang KH = new Khachhang(MAKH, TEN, GT, NS);
            DSKH.Add(KH);
        }
        static void dataEmployee(List<Nhanvien> DSNV)
        {
            foreach (Nhanvien nv in DSNV)
            {
                nv.info();
            }
        }
        static void dataCustomer(List<Khachhang> DSKH)
        {
            foreach (Khachhang kh in DSKH)
            {
                kh.info();
            }
        }
        static void thongke(List<Khachhang> DSKH)
        {
            int KH_vip = 0;
            int KH_ThanhVien = 0;
            int KH_Moi = 0;

            foreach (Khachhang kh in DSKH)
            {
                if (kh.LoaiKH == "SieuCapVipPro") { KH_vip += 1; }
                else if (kh.LoaiKH == "ThanhVien") { KH_ThanhVien += 1; }
                else if (kh.LoaiKH == "Moi") { KH_Moi += 1; }
            }
            Console.WriteLine("\nThong Ke so luong khach hang");
            Console.WriteLine("So khach hang SieuCapVipPro: {0}", KH_vip);
            Console.WriteLine("So khach hang Thanh vien: {0}", KH_ThanhVien);
            Console.WriteLine("So khach hang Moi: {0}\n", KH_Moi);
        }
    }
}
