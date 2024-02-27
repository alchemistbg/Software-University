namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public Stack()
        {

        }

        public bool Contains(T item)
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this._top;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public T Peek()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            return _top.Value;
        }

        public T Pop()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            Node<T> currentTopNode = this._top;
            this._top = this._top.Next;
            this.Count--;
            return currentTopNode.Value;
        }

        public void Push(T item)
        {
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(item);
            newNode.Next = this._top;
            this._top = newNode;
            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this._top;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        //=> throw new NotImplementedException();
        {
            return this.GetEnumerator();
        }

        private void CheckIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException($"Stack is empty!");
            }
        }
    }
}