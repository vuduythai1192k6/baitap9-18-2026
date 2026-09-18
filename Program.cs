using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("nhap chuoi : ");
        String chuoi = Console.ReadLine();
        int dem = 0;
        for (int i = 0;i<chuoi.Length;i++)
        {
            if(!char.IsWhiteSpace(chuoi[i]) && !char.IsPunctuation(chuoi[i]))
            {
                dem++;
            }
        }
        Console.WriteLine("so luong ki tu la : "+ dem);
         
    }
}
