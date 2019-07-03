using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AvarageGrade { get { return Grades.Sum() / Grades.Count(); } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                students[i] = ReadInput(Console.ReadLine());
            }

            foreach (var student in students.Where(x=>x.AvarageGrade>=5.00).OrderBy(x=>x.Name).ThenByDescending(x=>x.AvarageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AvarageGrade:F2}");
            }
        }
		
        static Student ReadInput(string input)
        {
            string[] tokens = input.Split();
            List<double> grades = new List<double>();

            foreach (var token in tokens.Skip(1))
            {
                grades.Add(double.Parse(token));
            }
            
            return new Student
            {
                Name = tokens[0],
                Grades = grades
            };
        }
    }
}
