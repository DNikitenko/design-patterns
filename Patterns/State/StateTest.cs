using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class StateTest : IPatternTest
    {
        public void Run()
        {
            var wizard = new Wizard();
            while (!wizard.IsCompleted())
            {
                wizard.ProcessUserInput();
                wizard.NextStep();
            }

            Console.WriteLine("Wizard has been completed successfully; press any key to exit");
            Console.ReadKey();
        }
    }
}
