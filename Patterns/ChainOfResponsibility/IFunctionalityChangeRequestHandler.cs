using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Provides functionality change request handling
    /// </summary>
    interface IFunctionalityChangeRequestHandler
    {
        /// <summary>
        /// Handle request for simple refactoring that doesn't affect
        /// Carebook functionality (e.g., interface extracting, parameters reordering, etc.)
        /// </summary>
        /// <param name="changeDescription"></param>
        void HandleSimpleRefactoringRequest(string changeDescription);

        /// <summary>
        /// Handle request for a single page functionality change (e.g., page design)
        /// </summary>
        /// <param name="changeDescription"></param>
        void HandlePageBehaviorChangeRequest(string changeDescription);

        /// <summary>
        /// Handle request for some global changes
        /// </summary>
        /// <param name="changeDescription"></param>
        void HandleCarebookFunctionalityChangeRequest(string changeDescription);
    }
}
