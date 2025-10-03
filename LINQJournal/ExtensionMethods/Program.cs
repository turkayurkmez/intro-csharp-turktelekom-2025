// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

string companyName = "türk telekom";
var comanyTitle = companyName.ToTitleCase();



Console.WriteLine(comanyTitle);

Console.WriteLine("yüsra yaren kıraç".ToTitleCase());

string sampleTable = "Order Details";
Console.WriteLine(sampleTable.RemoveMiddleEmpty());

Console.WriteLine(new Random().NextLetter());
Console.WriteLine(new Random().NextLetter(isSymbol:true));
Console.WriteLine(new Random().NextPassword(10));