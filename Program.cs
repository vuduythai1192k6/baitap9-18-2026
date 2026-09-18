
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();

        int dem = 0;
        Console.Write("Nhap ky tu : ");
        char a = Console.ReadLine()[0];
        for (int i = 0; i < chuoi.Length; i++)
        {
            if (chuoi[i] == a)
                dem++;
        }
        Console.Write("So lan xuat hien cua " + a + " la : " + dem);
    }
}

