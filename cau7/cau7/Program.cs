using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071053");
        Console.WriteLine();

        int n;

        do
        {
            Console.Write("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Loi! Vui long nhap n > 0.");
            }

        } while (n <= 0);

        long tong = 0;
        long tongChan = 0;
        long tongLe = 0;

        // Dung vong lap for de tinh cac tong
        for (int i = 1; i <= n; i++)
        {
            tong += i;

            if (i % 2 == 0)
            {
                tongChan += i;
            }
            else
            {
                tongLe += i;
            }
        }

        // Dung vong lap while de tinh giai thua
        long giaiThua = 1;
        int j = 1;

        while (j <= n)
        {
            giaiThua *= j;
            j++;
        }

        // In ket qua
        Console.WriteLine();
        Console.WriteLine("===== KET QUA =====");
        Console.WriteLine("MSSV: 6551071053");
        Console.WriteLine("Tong 1 + 2 + ... + " + n + " = " + tong);
        Console.WriteLine("Tong cac so chan tu 1 den " + n + " = " + tongChan);
        Console.WriteLine("Tong cac so le tu 1 den " + n + " = " + tongLe);
        Console.WriteLine("Giai thua " + n + "! = " + giaiThua);
    }
}