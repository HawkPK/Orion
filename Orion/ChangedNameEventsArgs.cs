using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion
{
    public class ChangedNameEventsArgs : EventArgs
    {
        public string existName { get; set; }
        public string newName { get; set; }
    }
}
