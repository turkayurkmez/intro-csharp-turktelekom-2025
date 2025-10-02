// See https://aka.ms/new-console-template for more information
using LooselyCoupled;


Oyuncu oyuncu = new Oyuncu();
oyuncu.Giy(new Converse());

Employee employee = new Employee() { Name="Türkay"};
ItDepartment itDepartment = new ItDepartment { Name = "IT" };

employee.Department = itDepartment;