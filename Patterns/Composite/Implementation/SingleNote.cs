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
    /// Represents a sound consists of a single note
    /// </summary>
    class SingleNote : ISound
    {
        NoteEnum Note { get; set; }

        public SingleNote(NoteEnum note)
        {
            Note = note;
        }

        #region ISound interface implementation
        public void Play(bool needCarry)
        {
            if (needCarry)
            {
                Console.WriteLine(Note);
            }
            else
            {
                Console.Write(Note + " ");
            }
        }
        #endregion
    }
}
