using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Employees
{
    /// <summary>
    /// Represents a tester in Carebook company
    /// </summary>
    class Tester : CarebookEmployee
    {
        /// <summary>
        /// Creates new Tester object instance with specified full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="supervisor"></param>
        public Tester(string fullName, CarebookEmployee supervisor)
            : base(fullName, supervisor)
        {
        }
    }
}
