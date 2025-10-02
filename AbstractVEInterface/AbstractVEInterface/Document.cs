using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVEInterface
{

    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public abstract void Save();
        public abstract void Load();

        //Patronlar; PDF dosyalarının çıktısı alınmayacak dediğine göre; Print fonksiyonu abstract sınıfın bir üyesi olamaz
        //public abstract void Print();

        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı!");
        }
      

    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            Console.WriteLine("Excel dosyası açılıyor");
        }

        public void Print()
        {
            Console.WriteLine("Excel dosyası çıktı alınıyor");

        }

        public override void Save()
        {
            Console.WriteLine("Excel dosyası kaydediliyor.");

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("WORD dosyası çıktı alınıyor");
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

     
        public override void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
