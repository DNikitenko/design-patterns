using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Prototype
{
    /// <summary>
    /// Provides Clone() method
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ICloneable<T>
    {
        /// <summary>
        /// Returns a deep self-copy
        /// </summary>
        /// <returns></returns>
        T Clone();

        /// <summary>
        /// Returns a shallow self-copy
        /// </summary>
        /// <returns></returns>
        T GetShallowCopy();
    }
}
