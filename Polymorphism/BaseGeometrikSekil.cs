using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseGeometrikSekil //Base class
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public BaseGeometrikSekil(double genislik, double yukseklik)//Constructor
        {
            this.Width = genislik;
            this.Height = yukseklik;
        }

        public abstract double AlanHesapla();

    }
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double kenar) : base(kenar, kenar) { }//Constructor
        public override double AlanHesapla()
        {
            return Width * Height; // Kenar * Kenar
        }

    }
    public class Dikdortgen : BaseGeometrikSekil
    {
        public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }//Constructor
        public override double AlanHesapla()
        {
           return Height * Width; // Kenar * Kenar
        }
    }
    public class Ucgen : BaseGeometrikSekil
    {
        public Ucgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }//Constructor
        public override double AlanHesapla()
        {
            return (Width * Height) / 2;
        }
    }

}
