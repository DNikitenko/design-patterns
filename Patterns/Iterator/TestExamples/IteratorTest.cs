using Patterns.Iterator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.TestExamples
{
    class IteratorTest : IPatternTest
    {
        public void Run()
        {
            var rootNode = new BinaryTreeNode<int>
            {
                Value = 1,
                Left = new BinaryTreeNode<int>
                {
                    Value = 2,
                    Left = new BinaryTreeNode<int>
                    {
                        Value = 3
                    },
                    Right = new BinaryTreeNode<int>
                    {
                        Value = 4
                    }
                },
                Right = new BinaryTreeNode<int>
                {
                    Value = 5,
                    Right = new BinaryTreeNode<int>
                    {
                        Value = 6,
                        Left = new BinaryTreeNode<int>
                        {
                            Value = 7,
                            Left = new BinaryTreeNode<int>
                            {
                                Value = 8,
                                Left = new BinaryTreeNode<int>
                                {
                                    Value = 9
                                },
                                Right = new BinaryTreeNode<int>
                                {
                                    Value = 10
                                }
                            },
                            Right = new BinaryTreeNode<int>
                            {
                                Value = 11,
                                Left = new BinaryTreeNode<int>
                                {
                                    Value = 12
                                }
                            }
                        }
                    }
                }
            };

            var tree = new BinaryTree<int>(rootNode);

            //Usual iterator way
            foreach (var node in tree)
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine();

            //Yield return way
            foreach (var node in tree.AsEnumerable())
            {
                Console.WriteLine(node.Value);
            }

            Console.ReadLine();
        }
    }
}
