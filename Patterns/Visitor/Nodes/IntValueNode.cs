using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Nodes
{
    /// <summary>
    /// Represents a node containing some value (non-generic)
    /// </summary>
    class IntValueNode : Node
    {
        public IntValueNode(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Value of any type
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Calls appropriate method for value in Visitor class
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(Visitors.Visitor visitor)
        {
            visitor.VisitValueNode(this);
        }
    }
}
