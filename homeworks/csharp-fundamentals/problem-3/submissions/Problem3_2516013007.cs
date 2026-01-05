using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;
            for (int i = 1; i <= n; i++) sonuc *= i;
            return sonuc;
        }

        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> seriler = new List<int>();
            if (adet <= 0) return seriler;
            int a = 0, b = 1;
            while (seriler.Count < adet)
            {
                seriler.Add(a);
                int gecici = a + b;
                a = b;
                b = gecici;
            }
            return seriler;
        }

        public static int BasamakSayisi(int sayi)
        {
            int basamak = 0;
            sayi = Math.Abs(sayi);
            do { sayi /= 10; basamak++; } while (sayi > 0);
            return basamak;
        }

        public static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
                if (sayi % i == 0) return false;
            return true;
        }

        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++) toplam += i;
            return toplam;
        }
    }
}