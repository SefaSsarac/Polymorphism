using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        // Kare Nesnesi Oluşturma ve Alan Hesaplama
        Kare kare1 = new Kare();
        kare1.Genislik = 5;
        kare1.Yukseklik = 5;
        Console.WriteLine($"Kare Alanı: {kare1.AlanHesapla()}");

        // Dikdörtgen Nesnesi Oluşturma ve Alan Hesaplama
        Dikdortgen dikdortgen1 = new Dikdortgen();
        dikdortgen1.Genislik = 4;
        dikdortgen1.Yukseklik = 7;
        Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen1.AlanHesapla()}");

        // Dik Üçgen Nesnesi Oluşturma ve Alan Hesaplama
        DikUcgen dikUcgen1 = new DikUcgen();
        dikUcgen1.Genislik = 3;
        dikUcgen1.Yukseklik = 6;
        Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen1.AlanHesapla()}");
    }
}