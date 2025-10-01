
using OverloadingAndOptionalParam;

Console.WriteLine();
double daireAlani = Geometri.AlanHesapla(5, Geometri.DAIRE);
double kareAlani = Geometri.AlanHesapla(5, Geometri.KARE);
Console.WriteLine(daireAlani);
Console.WriteLine(kareAlani);

double ucgen = Geometri.AlanHesapla(4, 8, Geometri.UCGEN);
double dikdörtgen = Geometri.AlanHesapla(5, 6, Geometri.DIKDORTGEN);

Console.WriteLine($"Üçgen: {ucgen}");
Console.WriteLine($"Dikdörtgen: {dikdörtgen}");

var optKare = Geometri.OptionalAlanHesapla(4);
Console.WriteLine(optKare);

var optDaire = Geometri.OptionalAlanHesapla(4.2, sekil: Geometri.DAIRE);
Console.WriteLine(optDaire);

var optUcgen = Geometri.OptionalAlanHesapla(5,3,Geometri.UCGEN);

Console.WriteLine("Optional Parametre ile hesaplandı....");
Console.WriteLine($"Kare:{optKare}\nDaire:{optDaire}\nÜçgen:{optUcgen}");