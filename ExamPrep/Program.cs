using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double studentCount = double.Parse(Console.ReadLine());
            double lectureCount = double.Parse(Console.ReadLine());
            double bonusLectures = double.Parse(Console.ReadLine());
            //Attendance for the students in the course
            List<Student> studentResult = new List<Student>();
            for (int i = 0; i < studentCount; i++)
            {
                double studenAtendance = double.Parse(Console.ReadLine());
                double bonus = Math.Round(studenAtendance / lectureCount * (5 + bonusLectures), MidpointRounding.AwayFromZero);
                Student student = new Student(bonus, studenAtendance);
                studentResult.Add(student);
            }
            studentResult = studentResult.OrderByDescending(x => x.Bonus).ToList();
            Console.WriteLine($"Max Bonus: {studentResult[0].Bonus}.\nThe student has attended {studentResult[0].Attendance} lectures.");
        }
    }
    class Student
    {
        public Student(double bonus, double attendance)
        {
            Bonus = bonus;
            Attendance = attendance;
        }

        public double Bonus { get; set; }
        public double Attendance { get; set; }
    }
}
