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
            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(10);
            gradeBook.AddGrade(10.6f);
        }
    }
}
