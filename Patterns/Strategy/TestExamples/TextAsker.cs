using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.TestExamples
{
    /// <summary>
    /// Client class for strategy pattern. Provides methods for text input and its validation
    /// </summary>
    class TextAsker
    {
        readonly IValidator _validator;

        public TextAsker(IValidator validator)
        {
            _validator = validator;
        }

        /// <summary>
        /// Ask user to enter a text and validate its input
        /// </summary>
        /// <returns>Has an input been validated</returns>
        public bool TryInputValue()
        {
            Console.WriteLine("Validating string using " + _validator.GetType().Name + ". Input a value:");
            var value = Console.ReadLine();

            return _validator.Validate(value);
        }
    }
}
