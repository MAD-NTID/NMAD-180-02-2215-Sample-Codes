using System;

namespace StudentGradeTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGrade[] students = new StudentGrade[10];

            for(int i = 0; i< 3; i++)
            {
                Console.Write("Enter student grade:");
                int grade = int.Parse(Console.ReadLine());

                StudentGrade student = new StudentGrade(grade);
                students[i] = student;

            }

            for(int i = 0; i< students.Length; i++)
            {
                if(students[i]!=null)
                    Console.WriteLine(students[i].Grade);
            }

            foreach (StudentGrade student in students)
            {
                if(student is null)
                    Console.WriteLine("This is empty we will skip");
                else if(student is not null)
                    Console.WriteLine(student.Grade);
            }

            //StudentGrade student1 = new StudentGrade(-100);
            //StudentGrade student2 = new StudentGrade();

            //student1.Course = "NMAD-180";

            //Console.WriteLine(student1.Grade);

            //Console.WriteLine(student1.Course);

            //student1.SetGrade(100);


            //Console.WriteLine(student1.GetGrade());
        }
    }
}
