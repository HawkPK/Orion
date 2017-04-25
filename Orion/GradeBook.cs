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
            _name = "Empty";
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

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        ChangedNameEventsArgs changeName = new ChangedNameEventsArgs();
                        changeName.existName = _name;
                        changeName.newName = value;
                        NameChange(this, changeName);
                    }
                    _name = value;
                }
            }
        }

        public NameDelegate NameChange;

        private string _name;
        List<float> grades = new List<float>();
        private float sum;
    }
}
