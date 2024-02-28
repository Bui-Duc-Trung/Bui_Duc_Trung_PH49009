using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bui_Duc_Trung_PH49009
{
    internal class SVUDPM: SinhVien
    {
        private int KyHocHienTai { get; set; }
        public SVUDPM()
        {
            
        }

        public SVUDPM(string maSV, string ten, int namSinh, double diem, int kyhochientai) : base(maSV, ten, namSinh, diem)
        {
            this.KyHocHienTai = kyhochientai;
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Ky hoc hien tai: {this.KyHocHienTai}");
        }
    }
}
