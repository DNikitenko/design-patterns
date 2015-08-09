using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Employees
{
    /// <summary>
    /// Represents a software developer in Carebook company
    /// </summary>
    class Developer : CarebookEmployee
    {
        /// <summary>
        /// Creates new Developer object instance with specified full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="supervisor"></param>
        public Developer(string fullName, CarebookEmployee supervisor)
            : base(fullName, supervisor)
        {
        }

        /// <summary>
        /// Developer can make a decision about small refactoring
        /// </summary>
        /// <param name="changeDescription"></param>
        public override void HandleSimpleRefactoringRequest(string changeDescription)
        {
            Console.WriteLine(
                String.Format("{0} should perform next refactoring: {1}", FullName, changeDescription));
        }
    }
}
