using Patterns.Visitor.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor.TestExamples
{
    class VisitorTest : IPatternTest
    {
        public void Run()
        {
            var root = new BinaryOperationNode
            {
                Operation = Enums.OperationType.Addition,
                LeftArgument = new BinaryOperationNode
                {
                    Operation = Enums.OperationType.Distraction,
                    LeftArgument = new IntValueNode(1),
                    RightArgument = new IntValueNode(2)
                },
                RightArgument = new BinaryOperationNode
                {
                    Operation = Enums.OperationType.Addition,
                    LeftArgument = new IntValueNode(3),
                    RightArgument = new IntValueNode(5)
                }
            };

            var treePrinter = new Patterns.Visitor.Visitors.TreePrinterVisitor();
            root.Accept(treePrinter);

            var xmlPrinter = new Patterns.Visitor.Visitors.XmlPrinterVisitor();
            root.Accept(xmlPrinter);

            Console.ReadLine();
        }
    }
}
