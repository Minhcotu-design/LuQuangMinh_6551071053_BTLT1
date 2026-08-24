using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
        static void Main(string[] args)
        {
            // In MSSV
            Console.WriteLine("MSSV: 6551071053");
            Console.WriteLine();

            // Nhap nhiet do Celsius
            Console.Write("Nhap nhiet do Celsius: ");
            decimal celsius = decimal.Parse(Console.ReadLine());

            // Chuyen doi sang Fahrenheit
            decimal fahrenheit = celsius * 9 / 5 + 32;

            // Chuyen doi sang Kelvin
            decimal kelvin = celsius + 273.15m;

            // In ket qua, lam tron 2 chu so thap phan
            Console.WriteLine();
            Console.WriteLine("--- KET QUA ---");
            Console.WriteLine($"Celsius: {celsius:F2} °C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Kelvin: {kelvin:F2} K");
        }
    }
}