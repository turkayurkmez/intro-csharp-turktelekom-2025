using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdas
{
    public class Filters
    {
        //int tipinde parametre alıp bool döndüren, erkek adaylar için askerlik sorunu bulunmayan, seyahat edebilir fonksiyonlar aranıyor :)

       // public delegate bool Criteria(int i);
        //artık delegate yazmak yerine hazır generic built-in delegate tanımları kullanıyoruz
        public static  int[] Filter(int[] numbers, Func<int,bool> criteria)
        {
          
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }

    }
}
