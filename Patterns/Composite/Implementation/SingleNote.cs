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
    [Serializable]
    class SingleNote : ISound
    {
        NoteEnum Note { get; set; }

        public SingleNote(NoteEnum note)
        {
            Note = note;
        }

        #region ISound interface implementation
        public void Play(bool needCarry = true)
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

        #region IDeepCloneable interface implementation
        /// <summary>
        /// The same as GetShallowCopy()
        /// </summary>
        /// <returns></returns>
        public ISound Clone()
        {
            return GetShallowCopy();
        }

        /// <summary>
        /// Shallow copy is quite enough here because there's only a enum member here
        /// </summary>
        /// <returns></returns>
        public ISound GetShallowCopy()
        {
            return (ISound)MemberwiseClone();
        }
        #endregion
    }
}
