using System;
using System.Collections;

class Program
{

    static void Main(string[] args)
    {

        char[] harfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        string metin;
        int sayac = 0;
        Console.WriteLine("Metin giriniz : ");
        metin = Console.ReadLine();
        for (int i = 0; i < harfler.Length; i++)
        {
            for (int j = 0; j < metin.Length; j++)
            {
                if (metin[j] == harfler[i])
                {
                    sayac++;
                }
            }
        }
        Console.WriteLine(sayac);
        Console.ReadLine();
    }
}