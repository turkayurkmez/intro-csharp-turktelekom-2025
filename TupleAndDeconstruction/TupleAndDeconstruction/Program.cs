// See https://aka.ms/new-console-template for more information
using TupleAndDeconstruction;

Console.WriteLine("Hello, World!");
/*
 * Problem. Bir fonksiyon olsun. İki sayının birbirlerine bölünce çıkan sonucu ve kalan bilgisini döndürsün
 */

int bolme(int a,  int b, out int kalan)
{
    kalan = a % b;
    return a / b;
}

int modulo = 0;
int sonuc = bolme(15, 7, out modulo);
Console.WriteLine($"out parametresi ile bölme sonucu: {sonuc}, kalan:{modulo}");

//Out parametresi yerine başka ne olabilir?
BolmeSonucu bolmeIslemi(int a, int b)
{
    BolmeSonucu bolmeSonucu = new BolmeSonucu();
    bolmeSonucu.Sonuc = a / b;
    bolmeSonucu.Kalan = a % b;

    return bolmeSonucu;

}

var sonucNesne = bolmeIslemi(15, 7);
Console.WriteLine($"obje dönen bölme işlemi sonucu: {sonucNesne.Sonuc}, kalan ise {sonucNesne.Kalan} ");

Tuple<int,int> tupleileBolme(int a, int b)
{
    return Tuple.Create(a / b, a % b);
}

var tupleSonuc = tupleileBolme(15, 7);
Console.WriteLine($"Tuple ile Bölme işlemi sonucu: {tupleSonuc.Item1}, kalan ise {tupleSonuc.Item2} ");

(int sonuc, int kalan) decoBolme(int a, int b)
{
    return (a / b, a % b);
}

(int sonucDegeri, int kalanDegeri) = decoBolme(15, 7);

Console.WriteLine($"Tuple Deconstruction ile Bölme işlemi sonucu: {sonucDegeri}, kalan ise {kalanDegeri} ");

