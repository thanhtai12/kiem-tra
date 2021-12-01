using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTraQLNV
{
    class Nhansu
    {
        protected string maso;
        protected string ten;
        protected string gioiTinh;
        protected string ngaySinh;
    }
    class Nhanvien : Nhansu
    {
        private string bangCap;
        public string Ma { get => maso; set => maso = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        public Nhanvien(string manv, string hoten, string gioitinh, string ngaysinh, string bangcap)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            bangCap = bangcap;
        }
        public void info()
        {
            Console.WriteLine("\nNhan vien {0}", maso);
            Console.WriteLine(" Ho Ten: " + ten);
            Console.WriteLine(" Gioi tinh: " + gioiTinh);
            Console.WriteLine(" Ngay sinh: " + ngaySinh);
            Console.WriteLine(" Bang cap: " + bangCap);
        }
    }
    class Khachhang : Nhansu
    {
        private string loaiKH = "Moi";
        public string Ma { get => maso; set => maso = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public Khachhang(string manv, string hoten, string gioitinh, string ngaysinh, string loaikh)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            loaiKH = loaikh;
        }
        public Khachhang(string manv, string hoten, string gioitinh, string ngaysinh)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
        }
        public void info()
        {
            Console.WriteLine("\nThong tin nhan vien {0}", maso);
            Console.WriteLine(" Ho Ten: " + ten);
            Console.WriteLine(" Gioi tinh: " + gioiTinh);
            Console.WriteLine(" Ngay sinh: " + ngaySinh);
            Console.WriteLine(" Loai khach hang: " + loaiKH);
        }
    }
}