using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bui_Duc_Trung_PH49009
{
    internal class SinhVienService
    {
        List<SinhVien> sinhViens {  get; set; }
        public SinhVienService()
        {
            sinhViens = new List<SinhVien>();
        }
        public void Nhap()
        {
            int tieptuc = -1;
            do
            {
                Console.Write("Nhap ma SV: ");
                string masv = Console.ReadLine();
                Console.Write("Nhap Ten SV: ");
                string tensv = Console.ReadLine();
                Console.Write("Nhap nam sinh: ");
                int namsinh = int.Parse(Console.ReadLine());
                Console.Write("Nhap diem cua SV: ");
                double diemsv = double.Parse(Console.ReadLine());
                SinhVien sinhVien = new SinhVien(masv, tensv, namsinh, diemsv);
                sinhViens.Add(sinhVien);
                Console.WriteLine("Them SV thanh cong !");
                Console.Write("Co nhap tiep khong (1-Co/2-Khong): ");
                tieptuc = int.Parse(Console.ReadLine());
            } while (tieptuc == 1);
        }
        public void Xuat()
        {
            foreach(SinhVien sinhVien in sinhViens)
            {
                sinhVien.InThongTin();
            }
        }
        public void HappyBee()
        {
            foreach (SinhVien sinhVien in sinhViens)
            {
                if(sinhVien.GetDiem() >= 8)
                {
                    sinhVien.InThongTin();
                }
            }
        }
        public void Xoa()
        {
            Console.WriteLine("nhung sv khong duoc tham gia happybee: ");
            for (int i = sinhViens.Count - 1; i >= 0 ; i--)
            {

                if ((DateTime.Now.Year - sinhViens[i].GetNamSinh()) > 25)
                {
                    sinhViens[i].InThongTin();
                    sinhViens.RemoveAt(i);
                }
            }
        }   
        public void KeThua()
        {
            List<SVUDPM> sVUDPMs = new List<SVUDPM>();
            Console.Write("Nhap ma SV: ");
            string masv = Console.ReadLine();
            Console.Write("Nhap Ten SV: ");
            string tensv = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            int namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem cua SV: ");
            double diemsv = double.Parse(Console.ReadLine());
            Console.Write("Ky hoc hien tai: ");
            int kyhoc = int.Parse(Console.ReadLine());
            SVUDPM sinhVien = new SVUDPM(masv, tensv, namsinh, diemsv, kyhoc);
            //sVUDPMs.Add(sinhVien);
            //foreach (var item in sVUDPMs)
            //{
            //    item.InThongTin();
            //}
            sinhVien.InThongTin();
            
        }
    }
}
