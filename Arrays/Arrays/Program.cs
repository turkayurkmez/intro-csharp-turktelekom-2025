// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Tüm elemanları biliyorsanız:
string[] customers = { "Ali", "Türkay", "Cansu", "Zeynep" };
int[] ages = new int[customers.Length];
Console.WriteLine($"Toplam eleman sayısı: {customers.Length}\nİlk eleman: {customers[0]}\nSon eleman: {customers[customers.Length - 1]}");

Console.WriteLine($"Yeni range operatörü. Sondaki eleman: {customers[^1]}");
int start = 0;
int end = 2;

Console.WriteLine($"İlk iki eleman: {string.Join(",", customers[start..end])}");



int index = 0;
while (index < customers.Length)
{
    Console.WriteLine($"{customers[index]} isimli müşterinin yaşını girin: ");
    int age = Convert.ToInt32(Console.ReadLine());
    ages[index++] = age;

}

Console.WriteLine($"Girilen toplam yaş: {ages.Length} ");

string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

Console.WriteLine("Sayıyı girin");
int number = Convert.ToInt32(Console.ReadLine());

int onlarBasamagi = number / 10;
int birlerBasamagi = number % 10;
Console.WriteLine(onlar[onlarBasamagi] + " " + birler[birlerBasamagi]);


