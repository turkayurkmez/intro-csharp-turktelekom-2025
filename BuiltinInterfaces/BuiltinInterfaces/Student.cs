using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinInterfaces
{

    /*
     * Student sınıfı, IComperable<Student> interface'ini implemente ediyor çünkü; students.Sort() metodunun çalışabilmesi için CompareTo metoduna gereksinim duyuyor. Bu metod, üç ihtimal dönrüyüor. Eşitse 0, Karşılaştırılan nesne büyükse -1, küçükse +1
     */
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Score { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Score > other.Score)
            {
                return 1;
            }
            else if (this.Score < other.Score)
            {
                return -1;
            }

            return 0;

        }
    }

}
