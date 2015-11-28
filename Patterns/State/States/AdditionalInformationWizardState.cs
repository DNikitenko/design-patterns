using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    /// <summary>
    /// Ask user for extra info. E.g., full name
    /// </summary>
    class AdditionalInformationWizardState : WizardState
    {
        public override void ProcessInput()
        {
            Console.WriteLine("What's your full name?");
            Console.ReadLine();

            Console.WriteLine("Tell me baby, what's your story? (c)");
            Console.ReadLine();
        }

        public override WizardState GetNextState()
        {
            return null;
        }
    }
}
