using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{

    public interface IDepartment
    {
        int Id { get; set; }
        string Name { get; set; }

        string Description {  get; set; }

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IDepartment Department { get; set; }
    }

    public class Department : IDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Employee> Employees { get; set; }
        public Employee Manager { get; set; }

        public decimal Budget { get; set; }
    }

    public class ItDepartment : Department 
    {
        public bool IsIncludeReport { get; set; }
    }
}
