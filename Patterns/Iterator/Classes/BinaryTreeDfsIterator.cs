using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Classes
{
    class BinaryTreeDfsIterator<T> : IEnumerator<BinaryTreeNode<T>>
    {
        /// <summary>
        /// Tree root
        /// </summary>
        private BinaryTreeNode<T> _root;

        /// <summary>
        /// Last visited node
        /// </summary>
        private BinaryTreeNode<T> _previous;

        /// <summary>
        /// Current tree node
        /// </summary>
        private BinaryTreeNode<T> _current;

        /// <summary>
        /// Tree nodes stack to store current path
        /// </summary>
        private Stack<BinaryTreeNode<T>> _nodeStack;

        /// <summary>
        /// Default iterator constructor. Receives tree root as a parameter
        /// </summary>
        /// <param name="root">Tree root</param>
        public BinaryTreeDfsIterator(BinaryTreeNode<T> root)
        {
            _current = _root = root;

            _nodeStack = new Stack<BinaryTreeNode<T>>();
            _nodeStack.Push(_root);
        }

        /// <summary>
        /// Get current tree node
        /// </summary>
        public BinaryTreeNode<T> Current
        {
            get 
            {
                return _current;
            }
        }

        /// <summary>
        /// We don't have any resources to be disposed explicitly
        /// </summary>
        public void Dispose() { }

        /// <summary>
        /// Impleneted to support IEnumerator interface
        /// </summary>
        object System.Collections.IEnumerator.Current
        {
            get 
            {
                return Current;
            }
        }

        /// <summary>
        /// Changes current tree node to the next element in depth-first order
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            while (_nodeStack.Count > 0)
            {      
                //Current element is root
                if (_previous == null)
                {
                    _previous = _current;
                    return true;
                }
                //There is non-visited left node
                else if (_current.Left != null && _current.Left != _previous && _current.Right != _previous)
                {
                    _previous = _current;
                    _current = _current.Left;

                    _nodeStack.Push(_current);

                    return true;
                }
                //There if non-visited right node
                else if (_current.Right != null && _current.Right != _previous)
                {                                       
                    _previous = _current;
                    _current = _current.Right;
                    
                    _nodeStack.Push(_current);

                    return true;
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

            return false;
        }

        /// <summary>
        /// Not necessary to implement
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
