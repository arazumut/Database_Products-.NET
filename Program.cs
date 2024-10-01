using System;

class UrunCikisVeritabani
{
    // Global değişkenler
    static string urunIsmi;
    static decimal urunFiyati;
    static int urunMiktari;

    static void Main(string[] args)
    {
        Console.Write("Ürünün ismini giriniz: ");
        urunIsmi = Console.ReadLine();

        Console.Write("Ürünün fiyatını giriniz: ");
        urunFiyati = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ürünün miktarını giriniz: ");
        urunMiktari = Convert.ToInt32(Console.ReadLine());

        decimal toplamFiyat = urunFiyati * urunMiktari;


        Console.WriteLine("Ürün Bilgileri:");
        Console.WriteLine("İsim: " + urunIsmi);
        Console.WriteLine("Fiyat: " + urunFiyati);
        Console.WriteLine("Miktar: " + urunMiktari);
        Console.WriteLine("Toplam Fiyat: " + toplamFiyat);
    }
}