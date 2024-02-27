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
            this._top = null;
            this.Count = 0;
        }
        public Stack(Node<T> node)
        {
            this._top = node;
            this.Count = 1;
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
            this.IsEmpty();
            return this._top.Value;
        }

        public T Pop()
        {
            //throw new NotImplementedException();
            this.IsEmpty();

            T value = this._top.Value;
            this._top = this._top.Next;
            this.Count--;

            return value;
        }

        public void Push(T item)
        {
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(item, this._top);
            this._top = newNode;
            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
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

        private void IsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }
        }
    }
}