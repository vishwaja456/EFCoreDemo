using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.name = "Rao";
            student.id = 3;

            ApplicationDBContext context = new ApplicationDBContext();
            context.students.Add(student);
            context.SaveChanges();
            Console.WriteLine($"student with  name {student.name} added into the database");
        }
    }
}
