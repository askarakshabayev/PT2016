using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWroldExample
{
    class Student
    {
        // fields
        // methods
        public string name;
        public string surname;
        public double gpa;
        public string ID;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Student(string name, string surname, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return name + " " + surname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Aslan", "Mussin");
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
