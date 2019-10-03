using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array
{
    public class ArrayString
    {
        public ArrayString()
        {
        }

        public ArrayString(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name { get; set; }

        public int Age { get; internal set; }


        public void AccessStudents()
        {
            ArrayString[] students = new[]
                {
            new ArrayString("Rahul", 27),
            new ArrayString("Rohit", 25),
            new ArrayString("Mohit", 23),
            new ArrayString("Tim", 25),
            new ArrayString("John", 23),
        };

            foreach (var student in students)
            {
                Console.WriteLine("Name:- " + student.Name + "Age:- " + student.Age);
            }
        }
    }
}
