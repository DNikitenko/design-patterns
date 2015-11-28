using Patterns.State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    /// <summary>
    /// Represents a wizard for account creation
    /// </summary>
    class Wizard
    {
        /// <summary>
        /// Current wizard state
        /// </summary>
        private WizardState _state;

        /// <summary>
        /// Creates new object of user wizard initialized with first state (email input)
        /// </summary>
        public Wizard()
        {
            _state = new InitialWizardState();
        }

        /// <summary>
        /// Ask user to input new data and processd data
        /// </summary>
        public void ProcessUserInput()
        {
            _state.ProcessInput();
        }

        /// <summary>
        /// 
        /// </summary>
        public void NextStep()
        {
            _state = _state.GetNextState();
        }

        /// <summary>
        /// Did user reach the end of wizard
        /// </summary>
        /// <returns></returns>
        public bool IsCompleted()
        {
            return _state == null;
        }
    }
}
