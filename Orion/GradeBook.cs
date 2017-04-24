using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    public class GradeBook
    {

        public GradeBook()
        {

        }

        public ComputeStatistics ComputeStatistics()
        {
            ComputeStatistics statics = new ComputeStatistics();

            foreach(float num in grades)
            {
                statics.MaxGrade = Math.Max(num, statics.MaxGrade);
                statics.MinGrade = Math.Min(num, statics.MinGrade);

                sum += num;
            }

            statics.AvgGrade = sum / grades.Count;

            return statics;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();
        private float sum;
    }
}
