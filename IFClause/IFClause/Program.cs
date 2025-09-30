namespace IFClause
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı girin:");
            int sayi = Convert.ToInt32 (Console.ReadLine());
            bool ciftMi = sayi % 2 == 0; //eğer kalansız (0) bölünüyorsa true

            if (ciftMi)
            {
                Console.WriteLine($"{sayi} sayısı çift sayıdır!");
            }
            else 
            {
                Console.WriteLine($"{sayi} sayısı tek sayıdır");
            }


            // Console.WriteLine($"{sayi} sayısı tek sayıdır");

            Console.WriteLine("Doğum yılınızı giriniz");
            int dogumYili = Convert.ToInt32 (Console.ReadLine());
            int suAnkiYil = DateTime.Now.Year;
            int yas = suAnkiYil - dogumYili;

            string durum = "";

            if (yas < 18 && yas >= 3)
            {
                durum = "Çocuk";
            }
            else if (yas <35 && yas >= 18)
            {
                durum = "Genç";
            }
            else if (yas < 60 && yas >= 35)
            {
                durum = "Orta yaş";
            }
            else
            {
                durum = "Yaşlı";
            }

            Console.WriteLine($"{yas} yaşında olan birinin sıfatı: {durum}");



            // && -> And also: Eğer ilk önerme false ise diğerlerine BAKMA! sonuç false
            // || -> Or Else: Eğer ilk önerme true ise diğerlerine BAKMA! sonuç true
            Console.WriteLine("Kaçıncı aydayız?");
            int monthValue = Convert.ToInt32 (Console.ReadLine());
            if (monthValue == 12  || monthValue == 1|| monthValue == 2)
            {
                Console.WriteLine("Kış");
            }
            else if (monthValue == 3 || monthValue == 4 || monthValue ==5)
            {
                Console.WriteLine("İlk bahar");
            }
            

        }
    }
}
