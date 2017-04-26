using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    public abstract class GraderTrack : IGraderTrack
    {
        public abstract ComputeStatistics ComputeStatistics();
        public abstract void AddGrade(float grade);
        public abstract IEnumerator GetEnumerator();


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Null value is unexcepted");
                }
                if (_name != value)
                {
                    ChangedNameEventsArgs changeName = new ChangedNameEventsArgs();
                    changeName.existName = _name;
                    changeName.newName = value;
                    //NameChange(this, changeName);
                }
                _name = value;

            }
        }

        public NameDelegate NameChange;
        protected string _name;
    }
}
