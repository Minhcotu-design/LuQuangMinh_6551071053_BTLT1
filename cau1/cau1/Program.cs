using System;

namespace ChaoHoiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // In MSSV
            Console.WriteLine("MSSV: 6551071053");
            Console.WriteLine();

            // Khai bao bien
            string hoTen;
            int tuoi;
            double chieuCao;
            float canNang;
            bool daTotNghiep;

            // Nhap du lieu
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Tuoi: ");
            tuoi = int.Parse(Console.ReadLine());

            Console.Write("Chieu cao (m): ");
            chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Can nang (kg): ");
            canNang = float.Parse(Console.ReadLine());

            Console.Write("Da tot nghiep (true/false): ");
            daTotNghiep = bool.Parse(Console.ReadLine());

            // Xuat du lieu
            Console.WriteLine("\n--- Thong tin cua ban ---");
            Console.WriteLine($"MSSV: 6551071053");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Tuoi: {tuoi}");
            Console.WriteLine($"Chieu cao: {chieuCao} m");
            Console.WriteLine($"Can nang: {canNang} kg");
            Console.WriteLine($"Da tot nghiep: {daTotNghiep}");
        }
    }
}