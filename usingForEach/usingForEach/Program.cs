// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

string[] malzemeler = { "defter", "kalem", "silgi", "kalemlik", "kitap" };

foreach (string malzeme in malzemeler)
{
    Console.WriteLine(malzeme);
}

object o = 45;
object p = "Deneme";

int kutudakiSayi = (int)o;
Console.WriteLine(kutudakiSayi);

ArrayList objeKoleksiyonu = new ArrayList();
objeKoleksiyonu.Add(45);

List<string> calisanlar = new List<string>();
calisanlar.Add("Barış Arı");
calisanlar.Add("Emre Doğanay");
calisanlar.Add("Eyüp Poyraz");

//List<string> tamamlanan = new List<string>();

foreach (var calisan in calisanlar)
{
    Console.WriteLine(calisan.ToUpper());
    //calisan = "Türkay";

    //calisanlar.Add("başka");

    //tamamlanan.Add(calisan);
}

calisanlar.Clear();

Console.WriteLine($"Çalışanlar koleksiyonunun eleman sayısı: {calisanlar.Count} ");
//foreach (var item in tamamlanan)
//{
//    calisanlar.Remove(item);
//}





