using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinInterfaces
{
    /*
     * Kendi nesnemde (classRoom) foreach ile dönebilmek için IEnumerable<Student> interface'ini implemente ettik.
     */
    public class ClassRoom : IEnumerable<Student>
    {
        private List<Student> students = new List<Student> ();

        public void AddStudent(Student student)
        {
            students.Add (student); 
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                //her student döndürdüğünde bir sonraki student'a geçmek için "yield" keyword'ü ile enumerate hale getirdik!
                yield return student;
            }
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void SortStudents()
        {
            students.Sort();
     
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
