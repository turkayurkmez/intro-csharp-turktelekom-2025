// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * 1. rastgele bir sayı tut.
 * 2. kullanıcının sayıyı tahmin etmesini iste.
 * 3. sayıyı karşılaştır ve yönlendir
 * 4. Bildiyse bir sonraki level'a geç.
 * 
 * 
 * 
 */





int getRandomNumber(int level)
{
    Random random = new Random();
    return random.Next(0, level * 100);
}

int getSuggestionFromUser()
{
    Console.WriteLine("Lütfen bir sayı giriniz:");
    return Convert.ToInt32(Console.ReadLine());
}

bool isFounded(int suggested, int generated)
{
    if (suggested > generated)
    {
        Console.WriteLine("Aşağı");
        return false;
    }
    else if (suggested < generated)
    {
        Console.WriteLine("Yukarı");
        return false;
    }
    Console.WriteLine("Bildiniz!");
    return true;
}

//int divide (int x, int y)
//{
//    return x / y;
//}

//void showMessage(string message)
//{
//    Console.WriteLine(message);
//}


//int output = divide(12, 3);

//showMessage(output.ToString());

int level = 1;
while (level <= 5)
{
    int randomNumber = getRandomNumber(level);
    bool isCompleted = false;
    while (!isCompleted)
    {
        int suggest = getSuggestionFromUser();
        isCompleted = isFounded(suggest, randomNumber); 
    }
    level++;
    Console.WriteLine($"{level}. aşamaya geçtiniz... Şimdi 1 ile {level *100} arasında sayıyı bulunuz" );
}