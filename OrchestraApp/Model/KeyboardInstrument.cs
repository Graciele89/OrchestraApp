using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraApp.Model
{
    public abstract class KeyboardInstrument : Instrument
    {

    }

    public class Piano : KeyboardInstrument
    {
        public override string Name { get => throw new NotImplementedException();
                                      set => throw new NotImplementedException(); }

        public override string Play()
        {
            throw new NotImplementedException();
        }
    }
}