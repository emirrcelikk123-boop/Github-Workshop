using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
      
        public static long Faktoriyel(int n)
        {
         
            if (n < 0) return 0; 
            
            long sonuc = 1; 
            
            
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }
            
            return sonuc;
        }

   
        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> seri = new List<int>();
            
            
            if (adet <= 0) return seri;
            
     
            seri.Add(0);
            
            
            if (adet == 1) return seri;
            
       
            seri.Add(1);
            
 
            int sayac = 2;
            
            while (sayac < adet)
            {
           
                int sonrakiSayi = seri[sayac - 1] + seri[sayac - 2];
                seri.Add(sonrakiSayi);
                sayac++;
            }
            
            return seri;
        }

      
        public static int BasamakSayisi(int sayi)
        {
          
            sayi = Math.Abs(sayi);
            
            int basamakSayisi = 0;
            
            do
            {
                sayi /= 10; 
                basamakSayisi++;
            } 
            while (sayi > 0);
            
           
            
            return basamakSayisi;
        }

        
        public static bool AsalMi(int sayi)
        {
        
            if (sayi < 2) return false;
            
          
            {
                if (sayi % i == 0)
                {
                    return false; 
                }
            }
            
            return true;
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            
            return toplam;
            
           
        }
    }
}