using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Nodes
{
    /// <summary>
    /// Represents tree node
    /// </summary>
    abstract class Node
    {
        /// <summary>
        /// 'Accept' method for node. Its implementation should call appropriate Visitor class method
        /// </summary>
        public abstract void Accept(Patterns.Visitor.Visitors.Visitor visitor);
    }
}
