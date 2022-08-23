using System;
using System.Collections;
using System.Collections.Generic;


namespace Koleksiyonlar{

    class Program{

        static void Main(string[] args){

            ArrayList sayılar = new ArrayList();
            int a ;
            int sayac = 0;
            ArrayList asalsayılar = new ArrayList();
            ArrayList asalolmayansayılar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("enter a number");
                a = Convert.ToInt32(Console.ReadLine());
                
                if (a is int)
                {
                   for (int k = 1; k <= a; k++)
                   {
                    if (a%k == 0)
                    {
                        sayac++;
                    }
                    
                   }
                   if (sayac == 2)
                   {
                    asalsayılar.Add(a);
                   }else{
                    asalolmayansayılar.Add(a);
                   }
                   
                }
            }
            
            asalsayılar.Sort();
            asalolmayansayılar.Sort();
            asalolmayansayılar.Reverse();
            asalsayılar.Reverse();
            Console.WriteLine(asalsayılar);
            Console.WriteLine(asalolmayansayılar);
            Console.WriteLine(asalsayılar.Count);
            Console.WriteLine(asalolmayansayılar.Count);
            
           

            
        }


       
    }
}
