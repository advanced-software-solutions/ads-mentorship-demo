using System;

namespace ASMentorship
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentService service = new StudentService();
            var student = new Student();
            student.Name = "Joe";
            student.DoB = new DateTime(1999, 1, 1);
            service.PrintDetails(student);
            Console.ReadLine();
        }
    }
}
