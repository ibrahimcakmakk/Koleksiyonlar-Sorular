using System;
using System.Collections;

class Program{

    static void Main(string[] args){

        ArrayList sayılar = new ArrayList();
        int a = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("lütfen sayı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            sayılar.Add(a);

        }
        sayılar.Sort();
        ArrayList min = new ArrayList();
        ArrayList max = new ArrayList();
        for (int i = 0; i < 3; i++)
        {
            min.Add(sayılar[i]);
        }
        sayılar.Reverse();
        for (int i = 0; i < 3; i++)
        {
            max.Add(sayılar[i]);
        }
        int summin = 0;
        int summax = 0;
        foreach (var item in min)
        {
            summin += Convert.ToInt32(item); 
        }
        foreach (var item in max)
        {
            summax += Convert.ToInt32(item); 
        }
        Console.WriteLine(summin/3);
        Console.WriteLine(summax/3);
        Console.WriteLine(summax + summin);
    }
}