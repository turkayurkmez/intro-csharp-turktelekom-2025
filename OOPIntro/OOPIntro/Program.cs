// See https://aka.ms/new-console-template for more information
using OOPIntro;

Console.WriteLine("Hello, World!");

Calisan yazilimci1 = new Calisan();
yazilimci1.Ad = "Türkay";

Calisan yazilimci2 = new Calisan();
yazilimci2.Ad = "Derya";

Calisan yazilimci3 = yazilimci1;
yazilimci3.Ad = "Necmiye";

Console.WriteLine(yazilimci1.Ad);

yazilimci1.Ad = "Nurten";
Console.WriteLine(yazilimci3.Ad);
