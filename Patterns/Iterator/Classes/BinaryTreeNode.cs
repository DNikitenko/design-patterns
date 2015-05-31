using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    /// <summary>
    /// Represents a node of any tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BinaryTreeNode<T>
    {
        /// <summary>
        /// Node value
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Left descendant
        /// </summary>
        public BinaryTreeNode<T> Left { get; set; }

        /// <summary>
        /// Right descendant
        /// </summary>
        public BinaryTreeNode<T> Right { get; set; }

        /// <summary>
        /// Override for comfortable debugging
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
