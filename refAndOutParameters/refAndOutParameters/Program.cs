// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void test(string message) //message bir input parametredir
{
    Console.WriteLine(message);
}

bool isInt(string value, out int number)
{
	try
	{
		number = Convert.ToInt32(value);
		return true;
	}
	catch (Exception)
	{
		number = 0;
		return false;
	}
}

void normalProcess(int value)
{
	value *= 2;
    Console.WriteLine($"normalProcess içinde value değeri: {value}");
}

void refProcess(ref int value)
{
    value *= 2;
    Console.WriteLine($"refProcess içinde value değeri: {value}");
}


//out Kullanımı
int outputVariable = 0;//boş tabak
string testValue = "8";
if (isInt(testValue, out outputVariable))
{
    Console.WriteLine($" {testValue.GetType().Name} tipindeki {testValue} değeri, tam sayıyya ({outputVariable.GetType().Name}) dönüştürüldü");
}

int number = 8;
normalProcess(number);
Console.WriteLine($"normalProcess metodunu çağırdıktan sonra number değeri: {number}");

refProcess(ref number);
Console.WriteLine($"refProcess metodunu çağırdıktan sonra number değeri: {number}");

