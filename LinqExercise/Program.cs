using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Order numbers in ascending order and print to the console
            numbers.OrderBy(x => x);
            foreach(int x in numbers)
                Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Order numbers in decsending order and print to the console
            numbers.OrderByDescending(x => x);
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Print to the console only the numbers greater than 6
            numbers.Where(n => n > 6);
            foreach(var n in numbers)
                Console.WriteLine(n);
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            numbers.OrderBy(x => x);
            foreach (var x in numbers.Take(4))
                { Console.WriteLine(x); }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 42;
            numbers.OrderByDescending(x => x);
            foreach(var x in numbers)
            { Console.WriteLine(x); }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filtered = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S')
                .OrderBy(x => x.FirstName);
            foreach (var x in filtered)
            { Console.WriteLine($"Fullname: {x.FullName}"); }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where(x => x.Age > 26)
                .OrderBy(x => x.Age).
                ThenBy(x => x.FirstName); 
            foreach (var x in overTwentySix)
            { Console.WriteLine($"Fullname: {x.FullName} Age: {x.Age}"); }
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var experience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"Sum: {experience.Sum(x=>x.YearsOfExperience)} Average: is {experience.Average(x=> x.YearsOfExperience)}");
            Console.WriteLine();
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-__");
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee( "Elijah", "Kariuki", 42, 3)).ToList();
            foreach(var x in employees)
            { Console.WriteLine($"First Name: {x.FirstName}, Last Name: {x.LastName}, Age: {x.Age}, YOE {x.YearsOfExperience}"); }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
