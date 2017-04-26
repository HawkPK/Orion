using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    public class ThrowGradeBook : GradeBook
    {

        public ComputeStatistics ComputeStatistics()
        {
            Console.WriteLine("Compute ThrowGradeBook");

            float minValue = float.MaxValue;

            foreach(float grade in grades)
            {
                minValue = Math.Min(minValue, grade);
            }

            grades.Remove(minValue);

            return base.ComputeStatistics();
        }

    }
}
