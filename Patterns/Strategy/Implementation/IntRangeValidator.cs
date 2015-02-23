using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.Implementation
{
    /// <summary>
    /// Provides range validation for integers
    /// </summary>
    class IntRangeValidator : IValidator
    {
        private readonly int _minValue;

        private readonly int _maxValue;

        public IntRangeValidator(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public bool Validate(string value)
        {
            int parsedValue;

            return Int32.TryParse(value, out parsedValue) &&
                   _minValue <= parsedValue && parsedValue <= _maxValue;
        }
    }
}
