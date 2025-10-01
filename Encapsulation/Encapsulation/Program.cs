// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Console.WriteLine("Fiyat giriniz:");
decimal price = Convert.ToDecimal(Console.ReadLine());

Product book = new Product();

book.SetPrice(price);
Console.WriteLine($"Ürün fiyatı, {book.GetPrice()} olarak atandı");
book.Name = "Albert Camus";
book.Category = "Yayınlar";

Console.WriteLine($"Ürün adı: {book.Name}, kategorisi: {book.Category}");


Console.WriteLine(book.InStock);
book.ChangeStock(100);
Console.WriteLine(book.InStock);
