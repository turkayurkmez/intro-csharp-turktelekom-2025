// See https://aka.ms/new-console-template for more information
using RecordTypes;

Console.WriteLine("Hello, World!");



ProductDto product = new ProductDto(1, "Güneş Gözlüğü", 1500, "Aksesuar");

Money dollar = new Money() { Amount = 10, Currency = "Dollar"};
Money dollar2 = new Money() { Amount = 10, Currency = "Dollar" };

//Money dollar2 = dollar;

Console.WriteLine($"class object karşılaştırması {dollar.Equals(dollar2)}");


//Record karşılaştırma:

RecordMoney recordDollar1 = new RecordMoney() { Amount=10, Currency="EUR"};
RecordMoney recordDollar2 = new RecordMoney() { Amount = 15, Currency = "EUR" };

Console.WriteLine($"Record karşılaştırması.... {recordDollar1 == recordDollar2}");

