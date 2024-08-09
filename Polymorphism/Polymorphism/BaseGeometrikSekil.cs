using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        // Base Class için Özellikler
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Polymorphism için Virtual Metot
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class Kare : BaseGeometrikSekil;
    public class Dikdortgen : BaseGeometrikSekil;
    public class DikUcgen : BaseGeometrikSekil
    {
        // DikUcgen için AlanHesapla metodunu override ediyoruz
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
    
