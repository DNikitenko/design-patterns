using Patterns.Composite.Enums;
using Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite
{
    /// <summary>
    /// Represents a series of single notes (or even chords if you're a kink :-))
    /// </summary>
    [Serializable]
    class Chord: ISound, IChord
    {
        private readonly IList<ISound> _chordNotes;
        
        public Chord(IList<ISound> notes)
        {
            _chordNotes = notes;
        }

        #region ISound interface implementation
        public void Play(bool needCarry = true)
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

        #region IDeepCloneable implementation
        public ISound Clone()
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();            
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);

                return (ISound)formatter.Deserialize(stream);
            }
        }

        public ISound GetShallowCopy()
        {
            return (ISound)MemberwiseClone();
        }
        #endregion
    }
}
