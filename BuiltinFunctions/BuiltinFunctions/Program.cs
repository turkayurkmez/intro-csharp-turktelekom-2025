// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/*
 * alternative.Add("A");
 * alternative.Add("B");
 * alternative.Add("C");
 * 
 * yerine collection intializer kullandık.
 * 
 */

List<string> alternative = new List<string>()
{
    "A","B","C"
};

List<string> emails = new List<string>();

string email = "";
do
{
    Console.WriteLine("Eposta adresini girin (Çıkmak için exit yazın)");
    email = Console.ReadLine();

    if (email != "exit")
    {
        if (email.Contains("@"))
        {
            emails.Add(email);
        }
        else
        {
            Console.WriteLine("eposta adresi @ işareti içermelidir");
        }
        
    }


   
    
   

} while (email != "exit");

Console.WriteLine(string.Join(", ", emails));
/*
 *  1. email içinde '@' işareti var mı?
 *  2. koleksiyondaki tüm adresleri, username ve domain olarak ayır.
 *  3. outlook, gmail ve yahoo.com olan domain dışındakileri göster.
 *  
 *  
 *  
 */

List<string> unwantedEmails = new List<string>()
{
    "outlook","gmail","yahoo"
};
Console.WriteLine("===================== Eposta analizi ======================");

foreach (var mail in emails)
{
    //a@b.com

    bool isUnwanted = unwantedEmails.Any(item => mail.Contains(item));

    //bool isUnwanted = false;
    //foreach (var unwanted in unwantedEmails)
    //{
    //    if (mail.Contains(unwanted))
    //    {
    //        isUnwanted = true;
    //    }
    //}

    if (!isUnwanted)
    {
        int indexOfAt = mail.IndexOf("@");
        string userName = mail.Substring(0, indexOfAt);
        string domain = mail.Substring(indexOfAt + 1);

        Console.WriteLine($"Kullanıcı adı: {userName}, Domain: {domain}");
    }

   


}
