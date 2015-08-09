using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Employees
{
    /// <summary>
    /// Represents a team leader in Carebook company
    /// </summary>
    class TeamLeader : CarebookEmployee
    {
        /// <summary>
        /// Creates new TeamLeader object instance with specified full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="supervisor"></param>
        public TeamLeader(string fullName, CarebookEmployee supervisor)
            : base(fullName, supervisor)
        {
        }

        /// <summary>
        /// Team leader is responsible for non-global functionality changes
        /// </summary>
        /// <param name="changeDescription"></param>
        public override void HandlePageBehaviorChangeRequest(string changeDescription)
        {
            Console.WriteLine(
                String.Format("{0} (team leader) has accepted next request: {1}", FullName, changeDescription));
        }
    }
}
