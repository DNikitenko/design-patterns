using Patterns.ChainOfResponsibility.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    /// <summary>
    /// Factory of Carebook team members
    /// </summary>
    class TeamFactory
    {
        /// <summary>
        /// Get product manager object
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static CarebookEmployee CreateProductManager(string fullName)
        {
            return new ProductManager(fullName);
        }

        /// <summary>
        /// Get team leader object
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="productManager"></param>
        /// <returns></returns>
        public static CarebookEmployee CreateTeamLeader(string fullName, CarebookEmployee productManager)
        {
            return new TeamLeader(fullName, productManager);
        }

        /// <summary>
        /// Get developer object
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="teamLeader"></param>
        /// <returns></returns>
        public static CarebookEmployee CreateDeveloper(string fullName, CarebookEmployee teamLeader)
        {
            return new Developer(fullName, teamLeader);
        }

        /// <summary>
        /// Get tester object
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="teamLeader"></param>
        /// <returns></returns>
        public static CarebookEmployee CreateTester(string fullName, CarebookEmployee teamLeader)
        {
            return new Tester(fullName, teamLeader);
        }
    }
}
