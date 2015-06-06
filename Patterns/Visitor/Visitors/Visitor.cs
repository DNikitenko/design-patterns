using Patterns.Visitor.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Visitors
{
    /// <summary>
    /// Represents a visitor class in GoF ther
    /// </summary>
    abstract class Visitor
    {
        /// <summary>
        /// Overriding methods should implement functionality for BinaryOperationNode element
        /// </summary>
        public abstract void VisitBinaryOperationNode(BinaryOperationNode operationNode);

        /// <summary>
        /// Overriding methods should implement functionality for ValueNode element
        /// </summary>
        public abstract void VisitValueNode(IntValueNode valueNode);
    }
}
