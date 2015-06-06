using Patterns.Visitor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Nodes
{
    /// <summary>
    /// Represents arithmetic operation
    /// </summary>
    class BinaryOperationNode : Node
    {
        /// <summary>
        /// Arithmetic operation
        /// </summary>
        public OperationType Operation { get; set; }

        /// <summary>
        /// Left operation argument
        /// </summary>
        public Node LeftArgument { get; set; }

        /// <summary>
        /// Right operation argument
        /// </summary>
        public Node RightArgument { get; set; }

        /// <summary>
        /// Calls appropriate method for binary operation in Visitor class
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(Visitors.Visitor visitor)
        {
            visitor.VisitBinaryOperationNode(this);
        }
    }
}
