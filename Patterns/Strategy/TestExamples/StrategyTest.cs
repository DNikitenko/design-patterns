using Patterns.Strategy.Implementation;
using Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy.TestExamples
{
    /// <summary>
    /// Provides Run() method to run Composite pattern test
    /// </summary>
    static class StrategyTest
    {
        public static void Run()
        {
            var validators = new IValidator[]
            {
                new EmptyStringValidator(),
                new IntRangeValidator(0, 100),
                new StringIsShitValidator()
            };

            foreach (var validator in validators)
            {
                var textInputter = new TextAsker(validator);
                if (textInputter.TryInputValue())
                {
                    Console.WriteLine("Great, your value is correct");
                }
                else
                {
                    Console.WriteLine("Aghh, you're wrong");
                }

                Console.WriteLine();
            }

            Console.WriteLine("We have no more questions. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
