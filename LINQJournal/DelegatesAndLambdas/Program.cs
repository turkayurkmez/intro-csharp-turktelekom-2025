// See https://aka.ms/new-console-template for more information
using DelegatesAndLambdas;

Console.WriteLine("Hello, World!");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


bool isEven(int number)
{
    return number % 2==0;
}



void showNumbers(int[] numbers)
{
    Console.WriteLine(string.Join(",",numbers));
}
//Version 1.0:
var version1 = Filters.Filter(numbers,isEven);
var version2 = Filters.Filter(numbers, delegate (int num) { return num % 2 == 1; });
var version3 = Filters.Filter(numbers, n => n >= 5);
var version4 = numbers.Where(x => x % 3 == 0).ToArray();

showNumbers(version4);
