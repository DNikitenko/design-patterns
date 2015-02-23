using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Interfaces
{
    /// <summary>
    /// Provides basic interface for string validators
    /// </summary>
    interface IValidator
    {
        /// <summary>
        /// Check if string is correct
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Validate(string value);
    }
}
