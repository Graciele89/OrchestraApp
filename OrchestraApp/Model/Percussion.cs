using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraApp.Model
{
    public abstract class PercussionInstrument : Instrument
    {

    }

    public class Drum : PercussionInstrument
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Play()
        {
            return $"I am playing a Drum";

        }

    }
}