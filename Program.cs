using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bui_Duc_Trung_PH49009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            SinhVienService sinhVienService = new SinhVienService();
            int chon = -1;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Nhap 1 danh sach doi tuong");
                Console.WriteLine("2. Xuat danh sach doi tuong");
                Console.WriteLine("3. Danh sach SV duoc tang ve Vip HappyBee");
                Console.WriteLine("4. Xoa SV khong duoc tham gia HappyBee");
                Console.WriteLine("5. Ke thua");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("------------------------------------------");
                Console.Write("Xin moi chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            sinhVienService.Nhap();
                            break;
                        }
                    case 2:
                        {
                            sinhVienService.Xuat();
                            break;
                        }
                    case 3:
                        {
                            sinhVienService.HappyBee();
                            break;
                        }
                    case 4:
                        {
                            sinhVienService.Xoa();
                            break;
                        }
                    case 5:
                        {
                            sinhVienService.KeThua();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Khong co chuc nang nay. Vui long chon lai !");
                            break;
                        }
                }
            }while(chon != 0);
        }
    }
}
