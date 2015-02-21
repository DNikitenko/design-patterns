using Patterns.Composite;
using Patterns.Composite.Enums;
using Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite.TestExamples
{
    /// <summary>
    /// Provides Run() method to run Composite pattern test
    /// </summary>
    static class CompositeTest
    {
        /// <summary>
        /// Run test
        /// </summary>
        public static void Run()
        {
            //Here is a music we want to play
            List<ISound> music = new List<ISound>();

            //First we create new sounds sequence
            ISound firstSound = SoundFactory.CreateNote(NoteEnum.C);
            ISound secondSound = SoundFactory.CreateChord(new[] { NoteEnum.C, NoteEnum.E });
            ISound thirdSound = SoundFactory.CreateNote(NoteEnum.C);

            music.Add(firstSound);
            music.Add(secondSound);
            music.Add(thirdSound);

            //Then we remember that life isn't great without G note, so we add it wo every chord
            ISound gNote = SoundFactory.CreateNote(NoteEnum.G);
            foreach (ISound sound in music)
            {
                if (sound is IChord)
                {
                    (sound as IChord).Add(gNote);
                }
            }

            //We can even even add one chord to another one:
            ISound oneMoreChord = SoundFactory.CreateChord(new[] { NoteEnum.D, NoteEnum.A });
            foreach (ISound sound in music)
            {
                if (sound is IChord)
                {
                    (sound as IChord).Add(oneMoreChord);
                }
            }

            //And now we finally "play" it (just writing out to console output)
            foreach (var sound in music)
            {
                //Here is Composite pattern essence: we call Play() method uniformly for all sounds: chords and single notes
                sound.Play(true);
            }

            Console.ReadKey();
        }
    }
}