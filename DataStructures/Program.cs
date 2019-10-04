using System;
using DataStructures.Array;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structures Program");

            ArrayNum obj = new ArrayNum();

            obj.AccessList();
            AccessStudents();
            TwoDimArray obj2 = new TwoDimArray();
            obj2.Access2DArray();

            Console.ReadLine();
        }

        private static void AccessStudents()
        {
            ArrayString[] students = {
                new ArrayString("Rahul", 27),
                new ArrayString("Rohit", 25),
                new ArrayString("Mohit", 23),
                new ArrayString("Tim", 25),
                new ArrayString("John", 23),
            };

            foreach (var student in students)
            {
                Console.WriteLine("Name:- " + student.Name + ", Age:- " + student.Age);
            }
        }
    }
}
