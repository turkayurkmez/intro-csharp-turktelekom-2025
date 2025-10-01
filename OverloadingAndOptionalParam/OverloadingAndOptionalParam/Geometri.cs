using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAndOptionalParam
{
    /*
 *  Kare,
 *  Daire,
 *  Üçgen ve
 *  Dikdörtgen 
 *  
 *  şekillerinin alanlarını hesaplamak istiyoruz....
 *  
 *  Kare: a^2  -> a
 *  Daire: Pi(r^2) -> r
 *  
 *  Üçgen: (a.h)/2 -> a, h
 *  Dikdörtgen: a * b -> a,b 
 *  
 *  
 *  
 *  
 */
    public static class Geometri
    {

        public const string KARE = "Kare";
        public const string DAIRE = "Daire";
        public const string UCGEN = "Üçgen";
        public const string DIKDORTGEN = "Dikdörtgen";
        /// <summary>
        /// Belirli geometrik şekillerin (Kare, Daire) alanlarını hesaplayan fonkiyon
        /// </summary>
        /// <param name="x">Daire için yarıçap, kare için kenar uzunluğu</param>
        /// <param name="sekil">Daire veya Kare</param>
        /// <returns>Belirtilen şeklin alan değeri</returns>
        /// <exception cref="ArgumentException">Daire veya Kare dışında bir kelime girerseniz hata alırsınız</exception>
        public static double AlanHesapla(double x, string sekil)
        {
            switch (sekil)
            {
                case Geometri.KARE:
                    return Math.Pow(x, 2);
                case Geometri.DAIRE:
                    return Math.Pow(x, 2) * Math.PI;
                default:
                    throw new ArgumentException("sekil parametresi Kare veya Daire olmalı");
                   
            }
        }


        /// <summary>
        /// Belirli geometrik şekillerin (Üçgen, Dikdörtgen) alanlarını hesaplayan fonkiyon
        /// </summary>
        /// <param name="x">Üçgen için taban kenar; dikdörtgen için kısa kenar</param>
        /// <param name="y">Üçgen için yükseklik; Dörtgen için uzun kenar</param>
        /// <param name="sekil">Şekil ya <see langword="Üçgen"/> ya da <see langword="Dikdörtgen"/> olmalı.</param>
        /// <returns>Belirtilen şekle göre hesaplanmış alan</returns>
        /// <exception cref="ArgumentException">Eğer <paramref name="sekil"/> parametresi, <see langword="Üçgen"/> ya da <see langword="Dikdörtgen"/> değilse hata verir</exception>
        public static double AlanHesapla(double x, double y, string sekil) {
            switch (sekil) {
                case Geometri.UCGEN:
                    return (x * y) / 2;
                case Geometri.DIKDORTGEN:
                    return x * y;
                default:
                    throw new ArgumentException("sekil parametresi Üçgen veya Dikdörtgen olmalı");
            }

        }

        public static double OptionalAlanHesapla(double x, double y=1, string sekil = Geometri.KARE)
        {
            switch (sekil)
            {
                case Geometri.KARE:
                    return Math.Pow(x, 2);
                case Geometri.DAIRE:
                    return Math.Pow(x, 2) * Math.PI;
                case Geometri.UCGEN:
                    return (x * y) / 2;
                case Geometri.DIKDORTGEN:
                    return x * y;
                default:
                    throw new ArgumentException("sekil parametresi Üçgen,Dikdörtgen, Daire veya Kare olmalı");
            }
        }
    }
}
