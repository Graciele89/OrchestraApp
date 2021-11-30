using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraApp
{
    public abstract class Instrument
    {
        public abstract string Name { get; set; }
        public abstract string Play();
    }
}