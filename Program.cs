using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += a[i];
        }

        Console.WriteLine("Tong cac phan tu = " + sum);
    }
}