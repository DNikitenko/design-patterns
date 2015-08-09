using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility.Employees
{
    /// <summary>
    /// Represents a product manager in Carebook company
    /// </summary>
    class ProductManager : CarebookEmployee
    {
        /// <summary>
        /// Creates new ProductManager object instance with specified full name
        /// </summary>
        /// <param name="fullName"></param>
        public ProductManager(string fullName) 
            : base(fullName, null)
        {
        }

        /// <summary>
        /// Product manager is responsible for global changes in the product
        /// </summary>
        /// <param name="changeDescription"></param>
        public override void HandleCarebookFunctionalityChangeRequest(string changeDescription)
        {
            Console.WriteLine(
                String.Format("As a PM, I'll think about next suggestion: {0}", changeDescription));
        }
    }
}
