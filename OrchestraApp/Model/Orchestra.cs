using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchestraApp.Model
{
    public class Orchestra : MusicGroup
    {
        public List<Instrument> Instruments = new List<Instrument>();

        public List<StringInstrument> StringSection = new List<StringInstrument>();

        public Orchestra()
        {
            Instruments.Add(new Drum());
            StringSection.Add(new Guitar());
            StringSection.Add(new Cello());
            StringSection.Add(new Harp());
            StringSection.Add(new Violin());
        }

        public override void Play()
        {
            foreach (Instrument currentInstrument in Instruments)
            {
                Console.WriteLine(currentInstrument.Play());
            }
            
            foreach (Instrument currentInstrument in StringSection)
            {
                Console.WriteLine(currentInstrument.Play());
            }
        }
    }
}