﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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
            
            Console.WriteLine($"Sum: {numbers.Sum()}");
            

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Order Acsending");
            var asc = numbers.OrderBy(x => x).ToList();
            foreach(var x in asc)
            {
                Console.WriteLine(x);
            }


            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Order Descending");

            var desc = numbers.OrderByDescending(x => x).ToList();
            foreach(var x in desc)
            {
                Console.WriteLine(x);
            }


            //TODO: Print to the console only the numbers greater than 6
            var sixAndUp = numbers.Where(x => x >= 6).ToList();
            foreach(var x in sixAndUp)
            {
                Console.WriteLine(x);
            }


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var onlyFour = numbers.OrderByDescending(x => x).Take(4).ToList();
            foreach(var x in onlyFour)
            {
                Console.WriteLine(x);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 36;
            var myAgeAtFour = numbers.OrderByDescending(x => x).ToList();
            foreach(var x in myAgeAtFour)
            {
                Console.WriteLine(x);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Starts with C or S");
            var cSNames = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList();
            foreach(var x in cSNames)
            {
                Console.WriteLine(x.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("26 over");
            var pleaseStop = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList();
            foreach(var x in pleaseStop)
            {
                Console.WriteLine($"{ x.FullName}, { x.Age}");
            }


            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine($"{yoe}");
            


            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var yoeTwo = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine($"{yoeTwo}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("William", "Summe", 36, 1)).ToList();
            foreach(var employ in employees)
            {
                Console.WriteLine(employ.FullName);
            }




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
