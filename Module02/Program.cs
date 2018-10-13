using SEDC.Academy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02
{
    class Program
    {
        private static readonly string _courseName = "OOP C# advanced";
        private static readonly string _className = "Module 1 - Interfaces, abstract classes and partial classes";
        private static readonly string _labName = "Lab 1 - Interfaces && Lab 2 - Abstract and partial classes";

        static void Main(string[] args)
        {
            CodeAcademyDailyReport();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void CodeAcademyDailyReport()
        {
            List<Trainer> trainers = new List<Trainer>();
            do
            {
                Console.WriteLine("Enter trainer full name");
                trainers.Add(new Trainer()
                {
                    FullName = Console.ReadLine()
                });
                Console.WriteLine("Press Y for another trainer:");
            }
            while (Console.ReadLine()== "Y");

            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("Enter Student full name");
                students.Add(new Student()
                {
                    FullName = Console.ReadLine()
            });
            Console.WriteLine("Press Y for another student");
            }
            while (Console.ReadLine()== "Y");


            foreach (var trainer in trainers)
            {
                Console.WriteLine(trainer.PrepareCourseMaterials(_courseName));
                Console.WriteLine(trainer.AttendClass(_className));
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.AttendClass(_className));
                Console.WriteLine(student.DoLabExercise(_labName));
            }
        }
    }
}
