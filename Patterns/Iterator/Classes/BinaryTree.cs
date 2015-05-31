using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class BinaryTree<T>
    {
        /// <summary>
        /// Tree root
        /// </summary>
        public BinaryTreeNode<T> Root { get; set; }

        /// <summary>
        /// Support foreach-style iteration. Depth-first way is used
        /// </summary>
        /// <returns></returns>
        public IEnumerator<BinaryTreeNode<T>> GetEnumerator()
        {
            return new BinaryTreeDfsIterator<T>(Root);
        }

        /// <summary>
        /// Yield return iterator implementation
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BinaryTreeNode<T>> AsEnumerable()
        {
            BinaryTreeNode<T> _previous = null;
            BinaryTreeNode<T> _current = Root;
            Stack<BinaryTreeNode<T>> _nodeStack = new Stack<BinaryTreeNode<T>>();
            _nodeStack.Push(Root);

            while (_nodeStack.Count > 0)
            {
                //Current element is root
                if (_previous == null)
                {
                    _previous = _current;
                    yield return _current;
                }
                //There is non-visited left node
                else if (_current.Left != null && _current.Left != _previous && _current.Right != _previous)
                {
                    _previous = _current;
                    _current = _current.Left;

                    _nodeStack.Push(_current);

                    yield return _current;
                }
                //There if non-visited right node
                else if (_current.Right != null && _current.Right != _previous)
                {
                    _previous = _current;
                    _current = _current.Right;

                    _nodeStack.Push(_current);

                    yield return _current;
                }
                //Current element is leaf or all descendants are already visited
                else
                {
                    _previous = _nodeStack.Pop();

                    //If stack is empty, we have finished the traverse
                    if (_nodeStack.Count > 0)
                    {
                        _current = _nodeStack.Peek();
                    }
                }
            }
        }

        /// <summary>
        /// Binary tree constructor
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(BinaryTreeNode<T> root)
        {
            Root = root;
        }
    }
}
