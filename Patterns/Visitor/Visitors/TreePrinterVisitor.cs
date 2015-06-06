using Patterns.Visitor.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.Visitors
{
    /// <summary>
    /// This class supports tree printing
    /// </summary>
    class TreePrinterVisitor : Visitor
    {
        /// <summary>
        /// Number of \t symbols to be printed before element string representation
        /// </summary>
        int indentionLelel = 0;

        /// <summary>
        /// Prints tabulation according to current indentionLelel variable value
        /// </summary>
        void PrintIndent()
        {
            for (int i = 0; i < indentionLelel; ++i)
            {
                Console.Write("\t");
            }
        }

        /// <summary>
        /// Prints binary operation as a tree
        /// </summary>
        /// <param name="operationNode"></param>
        public override void VisitBinaryOperationNode(BinaryOperationNode operationNode)
        {
            PrintIndent();
            Console.WriteLine(operationNode.Operation);

            ++indentionLelel;
            operationNode.LeftArgument.Accept(this);
            operationNode.RightArgument.Accept(this);
            --indentionLelel;
        }

        /// <summary>
        /// Prints value on the current indention level
        /// </summary>
        /// <param name="valueNode"></param>
        public override void VisitValueNode(IntValueNode valueNode)
        {
            PrintIndent();
            Console.WriteLine(valueNode.Value);
        }
    }
}
