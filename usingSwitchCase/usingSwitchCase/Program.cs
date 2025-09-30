// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Trafik ışığı ne renk (Kirmizi, Sari, Yesil)");
string color = Console.ReadLine();

//is operatörü ile bir nesnenin tipini denetleyebilirsiniz.
//if (color is string)
//{
//    Console.WriteLine("color değişkeninin tipi string");
//}


string state = "";
if (color == "Kirmizi")
{
    state = "Dur!";
}
else if (color == "Sari")
{
    state = "Dikkatli ol";
}
else if (color == "Yesil")
{
    state = "Geç";
}
else
{
    state = "Böyle bir renk yok!!";
}

    Console.WriteLine(state);

switch (color)
{
    case "Kirmizi":
        state = "Dur!";
        break;
    case "Sari":
        state = "Dikkatli ol";
        break;
    case "Yesil":
        state = "Geç";
        break;
    default:
        state = "Böyle bir renk yok!!";
        break;
}

Console.WriteLine(state);

DateTime today = DateTime.Now;

switch (today.DayOfWeek)
{ 
    case DayOfWeek.Monday: 
    case DayOfWeek.Tuesday:        
    case DayOfWeek.Wednesday:        
    case DayOfWeek.Thursday:
    case DayOfWeek.Friday:
        Console.WriteLine("Hafta içi...");
        break;
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Hafta sonu");    
        break;
    default:
        break;
}