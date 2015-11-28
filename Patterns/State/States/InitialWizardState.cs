using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State.States
{
    /// <summary>
    /// A first wizard state; we should ask user for an email
    /// </summary>
    class InitialWizardState : WizardState
    {
        public override void ProcessInput()
        {
            Console.WriteLine("Please enter your email");
            Console.ReadLine();
        }

        public override WizardState GetNextState()
        {
            return new AdditionalInformationWizardState();
        }
    }
}
