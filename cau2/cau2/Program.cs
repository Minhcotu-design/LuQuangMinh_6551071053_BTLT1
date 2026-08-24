using System;

namespace MayTinhDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            // In MSSV
            Console.WriteLine("MSSV: 6551071053");
            Console.WriteLine();

            // Nhap hai so thuc
            Console.Write("Nhap so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--- KET QUA CAC PHEP TOAN ---");

            // Cong
            Console.WriteLine($"Cong: {a} + {b} = {a + b}");

            // Tru
            Console.WriteLine($"Tru: {a} - {b} = {a - b}");

            // Nhan
            Console.WriteLine($"Nhan: {a} * {b} = {a * b}");

            // Chia
            Console.WriteLine($"Chia: {a} / {b} = {a / b}");

            // Chia lay phan nguyen
            Console.WriteLine($"Chia lay phan nguyen: {(int)(a / b)}");

            // Chia lay phan du
            Console.WriteLine($"Chia lay phan du: {(int)a % (int)b}");

            // Luy thua
            Console.WriteLine($"Luy thua: {a}^{b} = {Math.Pow(a, b)}");
        }
    }
}