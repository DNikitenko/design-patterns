using Patterns.Composite.Enums;
using Patterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Composite.Interfaces
{
    /// <summary>
    /// Represents basic interface to all sounds (i.e., single notes and chords)
    /// </summary>
    interface ISound : ICloneable<ISound>
    {
        /// <summary>
        /// Play sound
        /// </summary>
        /// <param name="needCarry">Shows if ne need to insert carry after printing a sound representation</param>
        void Play(bool needCarry = true);
    }
}
