using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bui_Duc_Trung_PH49009
{
    internal class SinhVien
    {
        private string MaSV { get; set; }
        private string Ten { get; set; }
        private int NamSinh { get; set; }
        private double Diem { get; set; }
        public SinhVien()
        {
            
        }

        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            MaSV = maSV;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"Ma SV: {this.MaSV} - Ten SV: {this.Ten} - Nam Sinh: {this.NamSinh} - Diem SV: {this.Diem}");
        }
        public double GetDiem() { return Diem; }
        public int GetNamSinh() { return NamSinh; }
    }

}
