using Patterns.Composite;
using Patterns.Composite.Enums;
using Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    class PrototypeTest : IPatternTest
    {
        public void Run()
        {
            /*Here we can see that shallow copy shares inner notes list with source chord,
            while deep copy has its own one.
            So, for example, in musical editor application we have to create deep copies
            if we want to copy-paste something*/

            var chord = SoundFactory.CreateChord(new[] { NoteEnum.C, NoteEnum.E });

            var shallowCopy = chord.GetShallowCopy();
            (shallowCopy as IChord).Add(SoundFactory.CreateNote(NoteEnum.D));

            var deepCopy = chord.Clone();
            (deepCopy as IChord).Add(SoundFactory.CreateNote(NoteEnum.D));

            Console.WriteLine("Source chord: ");
            chord.Play();

            Console.WriteLine("Deep copy: ");
            deepCopy.Play();

            Console.WriteLine("Shallow copy: ");
            shallowCopy.Play();

            Console.ReadKey();
        }
    }
}
