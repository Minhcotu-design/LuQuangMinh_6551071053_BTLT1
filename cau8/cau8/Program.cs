using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071053");
        Console.WriteLine();

        int[] mang = new int[10];

        // Nhap gia tri cho mang
        Console.WriteLine("===== NHAP MANG =====");

        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        // In toan bo mang bang foreach
        Console.WriteLine();
        Console.WriteLine("===== TOAN BO MANG =====");

        foreach (int x in mang)
        {
            Console.Write(x + " ");
        }

        // Tinh tong
        long tong = 0;

        foreach (int x in mang)
        {
            tong += x;
        }

        double trungBinh = (double)tong / mang.Length;

        // Tim lon nhat, nho nhat va vi tri
        int max = mang[0];
        int min = mang[0];
        int viTriMax = 0;
        int viTriMin = 0;

        for (int i = 1; i < mang.Length; i++)
        {
            if (mang[i] > max)
            {
                max = mang[i];
                viTriMax = i;
            }

            if (mang[i] < min)
            {
                min = mang[i];
                viTriMin = i;
            }
        }

        // Dem so chan va le
        int soChan = 0;
        int soLe = 0;

        foreach (int x in mang)
        {
            if (x % 2 == 0)
            {
                soChan++;
            }
            else
            {
                soLe++;
            }
        }

        // Dao nguoc mang
        int[] mangDao = new int[mang.Length];

        for (int i = 0; i < mang.Length; i++)
        {
            mangDao[i] = mang[mang.Length - 1 - i];
        }

        // In ket qua
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("===== KET QUA =====");
        Console.WriteLine("MSSV: 6551071053");
        Console.WriteLine("Tong cac phan tu: " + tong);
        Console.WriteLine("Trung binh cac phan tu: " + trungBinh);
        Console.WriteLine("Gia tri lon nhat: " + max + " - Vi tri: " + viTriMax);
        Console.WriteLine("Gia tri nho nhat: " + min + " - Vi tri: " + viTriMin);
        Console.WriteLine("So luong phan tu chan: " + soChan);
        Console.WriteLine("So luong phan tu le: " + soLe);

        Console.Write("Mang sau khi dao nguoc: ");

        foreach (int x in mangDao)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}