// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
int[] numbers = new int[10];
int index = 0;
Random random = new Random();
while (index < numbers.Length)
{
    int randomNumber = random.Next(-20, 100);
    numbers[index++] = randomNumber;
}

//en büyük:
var stopWatch = Stopwatch.StartNew();
int enBuyuk = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    
    if (numbers[i]> enBuyuk)
    {
        enBuyuk = numbers[i];
    }
}

stopWatch.Stop();
double forLoopBigOne = stopWatch.Elapsed.TotalMilliseconds;

//en küöük:
stopWatch.Restart();
int enKucuk = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < enKucuk)
    {
        enKucuk = numbers[i];
    }
}

stopWatch.Stop();

long forLoopSmallOne = stopWatch.ElapsedMilliseconds;

Console.WriteLine($"Tüm sayılar: {string.Join(", ",numbers)}");

Console.WriteLine($"En büyük değer: {enBuyuk}");
Console.WriteLine($"En küçük değer: {enKucuk}");

stopWatch.Restart();
Console.WriteLine($"En büyük değer - LINQ: {numbers.Max()}");
stopWatch.Stop();

long linqBigOne = stopWatch.ElapsedMilliseconds;

Console.WriteLine($"En küçük değer: {numbers.Min()}");
Console.WriteLine($"Ortalama değer: {numbers.Average()}");


Console.WriteLine($"for ile büyük sayı: {forLoopBigOne} ms\nfor ile küçük: {forLoopSmallOne} ms\nlinq ile büyük {linqBigOne} ms");