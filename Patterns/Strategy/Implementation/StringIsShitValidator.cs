using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Implementation
{
    /// <summary>
    /// Provides comparison with "shit" string validation
    /// </summary>
    class StringIsShitValidator: IValidator
    {
        public bool Validate (string value)
        {
            return value != "shit";
        }
    }
}
