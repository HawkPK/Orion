using System;
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
            IGraderTrack gradeBook = new ThrowGradeBook();

            //GetName(gradeBook);
            AddGrade(gradeBook);
            ShowResults(gradeBook);
        }

        private static void ShowResults(IGraderTrack gradeBook)
        {

            foreach(float grade in gradeBook)
            {

            }

            Console.WriteLine(gradeBook.Name);
            ComputeStatistics statics = gradeBook.ComputeStatistics();
            Console.WriteLine("Max value " + statics.MaxGrade);
            Console.WriteLine("Min value " + statics.MinGrade);
            Console.WriteLine("Avg value " + statics.AvgGrade);
        }

        private static void AddGrade(IGraderTrack gradeBook)
        {
            gradeBook.AddGrade(5);
            gradeBook.AddGrade(10);
            gradeBook.AddGrade(30);
            gradeBook.AddGrade(25);
            gradeBook.AddGrade(10.6f);
        }

        private static void GetName(GraderTrack gradeBook)
        {
            try
            {
                Console.WriteLine("Please write the name of GradeBook");
                gradeBook.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void OnNameChanged(object sender, ChangedNameEventsArgs changedName)
        {
            Console.WriteLine($"The name changed from {changedName.existName} to {changedName.newName}");
        }

    }
}
