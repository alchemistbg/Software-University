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
            this._head = null;
            this.Count = 0;
        }

        public Queue(Node<T> head)
        {
            this._head = head;
            this.Count = 1;
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
                };
                currentNode = currentNode.Next;
            }
            return false;
        }

        public T Dequeue()
        {
            //throw new NotImplementedException();
            this.isEmpty();
            Node<T> tempNode = this._head;

            this._head = this._head.Next;

            this.Count--;

            return tempNode.Value;
        }

        public void Enqueue(T item)
        {
            //throw new NotImplementedException();
            Node<T> current = this._head;
            Node<T> newNode = new Node<T>(item);

            if (current == null)
            {
                this._head = newNode;
                this._tail = newNode;
            }
            else
            {
                //while (current.Next != null)
                //{
                //    current = current.Next;
                //}
                //current.Next = newNode;

                //Optimized version of the enqueue method - it is O(1)
                this._tail.Next = newNode;
                this._tail = newNode;
            }
            this.Count++;
        }

        public T Peek()
        {
            //throw new NotImplementedException();
            this.isEmpty();
            return this._head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this._head;
            while (currentNode.Next != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //=> throw new NotImplementedException();
            return this.GetEnumerator();
        }

        private void isEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException($"The queue is empty!");
            }
        }
    }
}