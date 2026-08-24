using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071053");
        Console.WriteLine();

        // Nhap chuoi ho ten
        Console.Write("Nhap ho va ten day du: ");
        string hoTen = Console.ReadLine();

        // Do dai chuoi
        Console.WriteLine();
        Console.WriteLine("===== KET QUA =====");
        Console.WriteLine("Do dai chuoi: " + hoTen.Length);

        // Chuoi chu HOA
        Console.WriteLine("Chuoi chu HOA: " + hoTen.ToUpper());

        // Chuoi chu thuong
        Console.WriteLine("Chuoi chu thuong: " + hoTen.ToLower());

        // Xoa khoang trang hai dau
        string chuoiTrim = hoTen.Trim();
        Console.WriteLine("Chuoi sau khi Trim: " + chuoiTrim);

        // Kiem tra co chua tu "Nguyen" khong
        if (chuoiTrim.Contains("Nguyen"))
        {
            Console.WriteLine("Chuoi co chua tu \"Nguyen\".");
        }
        else
        {
            Console.WriteLine("Chuoi khong chua tu \"Nguyen\".");
        }

        // Tach chuoi thanh tung tu
        string[] danhSachTu = chuoiTrim.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        Console.WriteLine();
        Console.WriteLine("===== CAC TU TRONG HO TEN =====");

        foreach (string tu in danhSachTu)
        {
            Console.WriteLine(tu);
        }

        // Ghep lai bang dau "-"
        string chuoiGhep = String.Join("-", danhSachTu);

        Console.WriteLine();
        Console.WriteLine("Chuoi sau khi ghep bang dau \"-\": " + chuoiGhep);
    }
}