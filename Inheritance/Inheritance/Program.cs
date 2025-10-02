// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

KebapYemek kebapYemek = new KebapYemek() { AciliMi = true, Ad="Adana", PismeSuresi=20};
Baklava baklava = new Baklava() { Ad="Cevizli Baklava", SerbetliMi= true, Icerik="Ceviz", PismeSuresi=60};
Enginar enginar = new Enginar() { Ad="Enginar", LimonVarMi=true, PismeSuresi=45, SogukMu=true};

Asci asci = new Asci();
asci.Pisir(kebapYemek);
asci.Pisir(enginar);
asci.Pisir(baklava);

Console.WriteLine(baklava.ToString());

