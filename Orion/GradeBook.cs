using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    public class GradeBook : GraderTrack
    {

        public GradeBook()
        {
            _name = "Empty";
        }

        public override ComputeStatistics ComputeStatistics()
        {
            Console.WriteLine("Compute GradeBook");
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

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        protected List<float> grades = new List<float>();
        private float sum;
    }
}
