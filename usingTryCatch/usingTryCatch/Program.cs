namespace usingTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Birinci sayıyı girin...");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı girin...");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int bolum = sayi1 / sayi2;

                Console.WriteLine($"sonuç: {bolum}");
            }
            catch (FormatException)
            {

                Console.WriteLine("Lütfen yalnızca sayısal değer giriniz!");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tam sayılar 0'a bölünemez!!!");
            }
            catch (Exception ex) {
                Console.WriteLine($"Bir hata meydana geldi: {ex.Message} ");
            }
            finally
            {
                Console.WriteLine("Burası her zaman çalışır....");
            }


        }
    }
}
