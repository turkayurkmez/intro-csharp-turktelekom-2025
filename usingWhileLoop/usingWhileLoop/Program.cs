// See https://aka.ms/new-console-template for more information

/* Sayı bulunana kadar oyun devam eder.*/

Random random = new Random();
int tutulanSayi = random.Next(0, 101);
bool bulunduMu = false;
while (!bulunduMu)
{
    Console.WriteLine("Sayıyı tahmin edin:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin > tutulanSayi)
    {
        Console.WriteLine("Aşağı");
    }
    else if (tahmin < tutulanSayi)
    {
        Console.WriteLine("Yukarı");
    }
    else {
        Console.WriteLine("Bildiniz");
        bulunduMu = true;
    }
}

