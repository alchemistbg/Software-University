namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IAbstractQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        public Queue()
        {

        }

        public bool Contains(T item)
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this._head;
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

        public T Dequeue()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            Node<T> headNode = this._head;
            this._head = this._head.Next;
            this.Count--;
            return headNode.Value;
        }

        public void Enqueue(T item)
        {
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(item);

            if (this.Count == 0)
            {
                this._head = newNode;
                this._tail = newNode;
            }
            else
            {
                this._tail.Next = newNode;
                this._tail = newNode;
            }

            this.Count++;
        }

        public T Peek()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            return this._head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this._head;
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
                throw new InvalidOperationException("Stack is empty!");
            }
        }
    }
}