using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WinForm
{
    abstract class SV
    {
        private int maSV;//Ctrl+R+E
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;

        public int MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public SV()
        {
            this.maSV = 0;
            this.hoTen = "";
            this.ngaySinh = new DateTime();
            this.gioiTinh = true;
        }
        public SV(int masv, string ht, DateTime ns, bool gt)
        {
            this.maSV = masv;
            this.hoTen = ht;
            this.ngaySinh = ns;
            this.gioiTinh = gt;
        }
        abstract public float dTB();
        public virtual void hienThi()
        {
            Console.WriteLine($"MaSV:{this.maSV}");
            Console.WriteLine($"Ho va Ten:{this.hoTen}");
            Console.WriteLine($"Ngay sinh:{this.ngaySinh}");
            string gt = gioiTinh == true ? "Nam" : "Nu";
            Console.WriteLine($"Gioi tinh:{gt}");
            Console.WriteLine($"Diem TB:{dTB()}");
        }

    }
}
