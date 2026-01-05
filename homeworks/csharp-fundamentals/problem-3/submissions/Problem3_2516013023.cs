using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> fibonacciListesi = new List<int>();
            int a = 0;
            int b = 1;
            int sayac = 0;

            while (sayac < adet)
            {
                fibonacciListesi.Add(a);
                int gecici = a;
                a = b;
                b = gecici + b;
                sayac++;
            }

            return fibonacciListesi;
        }

        public static int BasamakSayisi(int sayi)
        {
            int basamakSayisi = 0;
            if (sayi < 0)
            {
                sayi = Math.Abs(sayi);
            }

            do
            {
                sayi /= 10;
                basamakSayisi++;
            } while (sayi > 0);

            return basamakSayisi;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
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
