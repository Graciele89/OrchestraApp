using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraApp.Model

{
    public abstract class StringInstrument : Instrument
    {
        public int numberOfStrings { get; set; }
        public int numberOfStringsViolin { get; set; }
        public int numberOfStringsHarp { get; set; }

        public StringInstrument()
        {
            numberOfStrings = 6;
            numberOfStringsViolin = 4;
            numberOfStringsHarp = 47;
        }
    }

    public class Guitar : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override string Play()
        {
            return $"I am playing a Guitar with {numberOfStrings} strings";
        }
    }



    public class Cello : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public override string Play()
        {
            return $"I am playing a Cello with {numberOfStrings} strings";
        }

    }


    public class Harp : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override string Play()
        {
            return $"I am playing a Harp with {numberOfStringsHarp} strings";
        }
    }


    public class Violin : StringInstrument
    {

        public override string Name
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public override string Play()
        {
            return $"I am playing a Violin with {numberOfStringsViolin} strings";
        }

    }

}