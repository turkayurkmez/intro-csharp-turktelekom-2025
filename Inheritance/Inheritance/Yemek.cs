using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Yemek
    {
        public string Ad { get; set; }
        public List<string> Malzemeler { get; set; }

        public int PismeSuresi { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{Ad}, {PismeSuresi} dakikada pişirildi");
        }

        //eğer miras alan isterse, bu metodu ezebilir (polymorphism) .
        public virtual void SunumYap()
        {
            Console.WriteLine($"{Ad} Yanında pilav ile sunuldu");
        }

        public override string ToString()
        {
            return Ad;
        }

        
    }

    public class EtYemek : Yemek
    {
        public string PismeDerecesi { get; set; }
    }

    public class KebapYemek: EtYemek
    {
        public bool AciliMi { get; set; }
    }

    public class ZeytinyagliYemek : Yemek
    {
        public bool SogukMu { get; set; }
    }

    public class Enginar: ZeytinyagliYemek
    {
        public bool LimonVarMi { get; set; }
    }

    public class Tatli: Yemek
    {
        public bool SerbetliMi { get; set; }
    }

    public class  Baklava: Tatli {
        public string Icerik { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{Ad} yanında dondurma ile ikram edildi");
        }
    }
    


}
