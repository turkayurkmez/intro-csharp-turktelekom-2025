// See https://aka.ms/new-console-template for more information
using PatternMatching;
using System.Xml;

Console.WriteLine("Hello, World!");

List<Person> people = new List<Person>()
{
     new Person(){ Id =1, Age = 25, City="Eskişehir", Name="Oğuz"},
     new Person(){ Id =4, Age = 32, City="Eskişehir", Name="Nalan"},

     new Person(){ Id =2, Age = 17, City="İstanbul", Name="Necla"},
     new Person(){ Id =3, Age = 36, City="Sakarya", Name="Betül"},


};

void findPerson(List<Person> people)
{
    foreach (var person in people)
    {
        if (person != null)
        {

            if (person.Age > 18)
            {
                if (person.City =="Eskişehir")
                {
                    if (person.Name == "Nalan")
                    {
                        Console.WriteLine($" {person.Name} isimli kişi bulundu");
                    }
                   
                }
            }
        }
    }
}


findPerson(people);

void findPersonWithPatternMatching(List<Person> people)
{
    foreach (var person in people) {
        if (person is { Age: > 18, Name:"Oğuz", City:"Eskişehir"  })
        {
            Console.WriteLine("Tek satırda eşleşen pattern bulundu...");
        }
    }
}

findPersonWithPatternMatching(people);

string getWeatherState(int celcius)
{
    return celcius switch
    {
        < 0 => "Sıfırın altında",
        >= 0 and < 5 => "Çok soğuk",
        >= 5 and < 15 => "Soğuk",
        >= 15 and < 24 => "Ilık"
    };
    

    //switch (celcius)
    //{
    //    case 0:
    //        return "sıfırın altında";
    //    case >= 0 and < 5:
    //        return "Çok soğuk";

    //    default:
    //        return "";

    //}
}


Console.WriteLine(getWeatherState(3));

string analyzePerson(Person person)
{
    return person switch
    {
        { Age: < 18} => "Genç",
        { Age: >=  65} => "Emekli",
        { Age:>=18, City:"Eskişehir"} => "Eskişehir'li yetişkin"

    };
}

string oldWayClassification(object obj)
{
    if (obj == null)
    {
        return "Null değer";
    }

    if (obj is string s)
    {
        if (s.Length < 2)
        {
            return "Kısa string";
        }

        if (s.Length> 10)
        {
            return "Uzun string";
        }
        else
        {
            return "Normal uzunlukta";
        }


    }
    else if (obj is int i)
    {
        if (i>100)
        {
            return "Büyük sayı";
        }

        if (i<100)
        {
            return "Küçük sayı";
        }

    }

    return "Tanımsız tür";
}


Console.WriteLine(oldWayClassification("merhaba"));
string modernWayClassification(object obj)
{
    return obj switch
    {
        null => "Null değer",
        string s when s.Length > 10 => "Uzun string",      
        string s when s.Length <= 2 => "Kısa string",
        string => "Normal uzunlukta string",
        int i when i > 100 => "Büyük sayı",
        int i when i < 100 => "Küçük sayı",
        _ => "Tanımsız tür"
    };
}

Console.WriteLine( modernWayClassification("merhaba"));

var car = new Car() {  Passengers= 2};
var taxi = new Taxi() { Fares = 5  };
var bus = new Bus() {  Capacity = 20, Riders= 2};
var truck = new Truck();

var calculator = new TotalCalculator();
Console.WriteLine($"Araba: {calculator.CalculateTicket(car)}");
Console.WriteLine($"Taksi: {calculator.CalculateTicket(taxi)}");
Console.WriteLine($"Otobüs: {calculator.CalculateTicket(bus)}");
Console.WriteLine($"Kamyon: {calculator.CalculateTicket(truck)}");