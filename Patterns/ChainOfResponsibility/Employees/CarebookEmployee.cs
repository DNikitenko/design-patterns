using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Base class for all the Carebook staff; shouldn't be instantiated directly
    /// </summary>
    class CarebookEmployee : IFunctionalityChangeRequestHandler
    {
        /// <summary>
        /// CarebookEmployee empty constructor (used to forbid direct CarebookEmployee instance creation)
        /// </summary>
        private CarebookEmployee()
        {
        }

        /// <summary>
        /// Employee's full name
        /// </summary>
        protected readonly string FullName;

        /// <summary>
        /// Employee's direct supervisor
        /// </summary>
        protected readonly IFunctionalityChangeRequestHandler Supervisor;

        /// <summary>
        /// Initializes CarebookEmployee instance with full employee's name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="supervisor"></param>
        protected CarebookEmployee(string fullName, CarebookEmployee supervisor)
        {
            FullName = fullName;
            Supervisor = supervisor;
        }

        #region IFunctionalityChangeRequestHandler implementation
        /// <summary>
        /// Default implementation just sends request to supervisor; override in derived classes,
        /// if another behavior is needed
        /// </summary>
        /// <param name="changeDescription"></param>
        public virtual void HandleSimpleRefactoringRequest(string changeDescription)
        {
            if (Supervisor != null)
            {
                Supervisor.HandleSimpleRefactoringRequest(changeDescription);
            }
        }

        /// <summary>
        /// Default implementation just sends request to supervisor; override in derived classes,
        /// if another behavior is needed
        /// </summary>
        /// <param name="changeDescription"></param>
        public virtual void HandlePageBehaviorChangeRequest(string changeDescription)
        {
            if (Supervisor != null)
            {
                Supervisor.HandlePageBehaviorChangeRequest(changeDescription);
            }
        }

        /// <summary>
        /// Default implementation just sends request to supervisor; override in derived classes,
        /// if another behavior is needed
        /// </summary>
        /// <param name="changeDescription"></param>
        public virtual void HandleCarebookFunctionalityChangeRequest(string changeDescription)
        {
            if (Supervisor != null)
            {
                Supervisor.HandleCarebookFunctionalityChangeRequest(changeDescription);
            }
        }
        #endregion
    }
}
