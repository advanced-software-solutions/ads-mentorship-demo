using System;

namespace ASMentorship
{
    public class StudentService : IStudentService
    {
        public virtual void PrintDetails(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, Dob: {student.DoB}");
        }

    }
}
