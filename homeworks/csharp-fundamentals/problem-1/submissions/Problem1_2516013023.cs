using System;

class Program
{
    static void Main(string[] args)
    {
     
        double sonuc1 = HesaplaOrtalama(70, 80);
        if (sonuc1 != -1) 
        {
            Console.WriteLine($"Ortalama: {sonuc1}");
        }

        double sonuc2 = HesaplaOrtalama(101, 80); 
        
        
        Console.ReadKey();
    }


    public static double HesaplaOrtalama(int vize, int final)
    {
      
        if (vize < 0 || vize > 100 || final < 0 || final > 100)
        {
            Console.WriteLine("Hata: Notlar 0 ile 100 arasında olmalıdır!");
            return -1;
        }
        else
        {
         
            double ortalama = (vize * 0.4) + (final * 0.6);
            return ortalama;
        }
    }
public static string BelirleHarfNotu(double ortalama, int final)
    {
        // Önce Final Barajı Kontrolü
        if (final < 50) 
            return "FF"; 

        // Harf Aralıkları
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
}

{
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

            case "FD":
            case "FF":
                return "Kaldı";

            default:
                return "Tanımsız";
        }
    }
}