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
    /// Represents a series of single notes (or even chords if you're a kink :-))
    /// </summary>
    class Chord: ISound, IChord
    {
        private readonly IList<ISound> _chordNotes;
        
        public Chord(IList<ISound> notes)
        {
            _chordNotes = notes;
        }
        #region ISound interface implementation
        public void Play(bool needCarry)
        {
            foreach (var note in _chordNotes)
            {
                note.Play(false);                
            }

            if (needCarry)
            {
                Console.WriteLine();
            }
        }
        #endregion
        #region IChord interface implementation
        public void Add(ISound note)
        {
            _chordNotes.Add(note);
        }
        #endregion
    }
}
