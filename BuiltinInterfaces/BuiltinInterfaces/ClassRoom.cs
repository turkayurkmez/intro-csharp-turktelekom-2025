using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinInterfaces
{
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
