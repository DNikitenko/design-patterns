using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    /// <summary>
    /// Represents current state of user account wizard
    /// </summary>
    abstract class WizardState
    {
        /// <summary>
        /// Request user data actual for current state
        /// </summary>
        public abstract void ProcessInput();

        /// <summary>
        /// Get next available state
        /// </summary>
        /// <param name="wizard"></param>
        public abstract WizardState GetNextState();
    }
}
