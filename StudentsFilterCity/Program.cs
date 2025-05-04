using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsFilterCity
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Town { get; set; }
        }
        static void Main(string[] args)
        {
            var studentsInfo = ReadInputStudentsData();

            string wantedCity = Console.ReadLine();

            foreach (Student student in studentsInfo)
            {
                if(student.Town == wantedCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

         static List<Student>  ReadInputStudentsData()
        {

            List<Student> studentData = new List<Student>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0] != "end")
            {
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string town = input[3];


                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Town = town;

                studentData.Add(student);
                input = Console.ReadLine().Split(' ').ToArray();

            }
            return studentData;
        }
    }
}
