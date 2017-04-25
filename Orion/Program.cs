﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook = new GradeBook();

            gradeBook.Name = "Super book";

            try {
                Console.WriteLine("Please write the name of GradeBook");
                gradeBook.Name = Console.ReadLine();
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            gradeBook.AddGrade(10);
            gradeBook.AddGrade(10.6f);

            gradeBook.ComputeStatistics();
            Console.WriteLine(gradeBook.Name);
            Console.WriteLine("Max value " + gradeBook.ComputeStatistics().MaxGrade);
            Console.WriteLine("Min value " + gradeBook.ComputeStatistics().MinGrade);
            Console.WriteLine("Avg value " + gradeBook.ComputeStatistics().AvgGrade);
        }

        static void OnNameChanged(object sender, ChangedNameEventsArgs changedName)
        {
            Console.WriteLine($"The name changed from {changedName.existName} to {changedName.newName}");
        }

    }
}
