using Patterns.Composite.Enums;
using Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    /// <summary>
    /// This is an example of Factory pattern. This class can create single notes and chords
    /// </summary>
    static class SoundFactory
    {
        public static ISound CreateNote(NoteEnum note)
        {
            return new SingleNote(note);
        }

        public static ISound CreateChord(IEnumerable<NoteEnum> notes)
        {
            var singleNotes = notes.ToList().ConvertAll(note => CreateNote(note));
            return new Chord(singleNotes);
        }
    }
}
