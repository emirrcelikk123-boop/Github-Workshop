using System;

namespace CSharpHomework
{
    public class Problem1
    {

        public static void Main(string[] args)
        {
            Console.Write("Vize Notunu Giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunu Giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = HesaplaOrtalama(vize, final);
            string harfNotu = BelirleHarfNotu(ortalama, final);
            string gecmeDurumu = BelirleGecmeDurumu(harfNotu);

            Console.WriteLine($"Ortalama: {ortalama}");
            Console.WriteLine($"Harf Notu: {harfNotu}");
            Console.WriteLine($"Geçme Durumu: {gecmeDurumu}");


            Console.ReadLine();
        }


        public static double HesaplaOrtalama(int vize, int final)
        {
            return (vize * 0.4) + (final * 0.6);
        }


        public static string BelirleHarfNotu(double ortalama, int final)
        {

            if (final < 50)
            {
                return "FF";
            }

            if (ortalama >= 90) return "AA";
            else if (ortalama >= 85) return "BA";
            else if (ortalama >= 80) return "BB";
            else if (ortalama >= 75) return "CB";
            else if (ortalama >= 70) return "CC";
            else if (ortalama >= 65) return "DC";
            else if (ortalama >= 60) return "DD";
            else if (ortalama >= 50) return "FD";
            else return "FF";
        }


        public static string BelirleGecmeDurumu(string harfNotu)
        {
            switch (harfNotu)
            {
                case "AA":
                case "BA":
                case "BB":
                case "CB":
                case "CC":
                    return "Geçti";
                case "DC":
                case "DD":
                    return "Şartlı Geçti";
                default: // FD ve FF durumları
                    return "Kaldı";
            }
        }
    }
}