using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course c1 = new Course();
            //c1.Id = 1;
            //c1.Name = "C#";
            //c1.Fees = 36000;

            //Console.WriteLine($"{c1.Id} {c1.Name} {c1.Fees}");

            //Course c2 = new Course { Id = 2, Name = "Java", Fees = 40000 };
            //Console.WriteLine($"{c2.Id} {c2.Name} {c2.Fees}");


            //Employee e1 = new Employee();
            //e1.Id = 1;
            //e1.Name = "Yogini";
            //e1.Salary = 36000;

            //Console.WriteLine($"{e1.Id} {e1.Name} {e1.Salary}");

            //Employee e2 = new Employee { Id = 2, Name = "Dhanu", Salary = 50000 };
            //Console.WriteLine($"{e2.Id} {e2.Name} {e2.Salary}");


            Student s1 = new Student();
            s1.Rollno = 20;
            s1.Name = "Yogini";
            s1.Percentage = 80;

            Console.WriteLine($"{s1.Rollno} {s1.Name} {s1.Percentage}");

            Student s2 = new Student { Rollno = 10, Name = "Saloni", Percentage = 85 };
            Console.WriteLine($"{s2.Rollno} {s2.Name} {s2.Percentage}");
        }
    }
}

