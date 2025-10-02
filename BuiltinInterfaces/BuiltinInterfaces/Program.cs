// See https://aka.ms/new-console-template for more information
using BuiltinInterfaces;

Console.WriteLine("Hello, World!");

Student student1 = new Student { Id = 1, Name = "Burak", Age = 26, Score = 95 };
Student student2 = new Student { Id = 2, Name = "Defne", Age = 34, Score = 83 };
Student student3 = new Student { Id = 3, Name = "Türkay", Age = 45, Score = 70 };

ClassRoom classRoom = new ClassRoom();
classRoom.AddStudent(student1);
classRoom.AddStudent(student2);
classRoom.AddStudent(student3);


Console.WriteLine("----------- Sıralama olmadan --------------");
foreach (var student in classRoom)
{
    Console.WriteLine($"{student.Name} isimli {student.Age} yaşındaki öğrencinin puanı: {student.Score}");
}

Console.WriteLine("----------- Sıralama yaptıktan sonra --------------");

classRoom.SortStudents();
foreach (var student in classRoom)
{
    Console.WriteLine($"{student.Name} isimli {student.Age} yaşındaki öğrencinin puanı: {student.Score}");
}