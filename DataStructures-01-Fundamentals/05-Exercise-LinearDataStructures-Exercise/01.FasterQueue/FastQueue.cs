namespace Problem01.FasterQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class FastQueue<T> : IAbstractQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        //public FastQueue()
        //{

        //}

        public bool Contains(T item)
        {
            //throw new NotImplementedException();
            Node<T> current = this._head;
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T Dequeue()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            Node<T> temp = this._head;

            this._head = this._head.Next;
            this.Count--;
            return temp.Item;

            //Kiro solution
            //this.ValidateIsEmpty();

            //Node<T> temp = this._head;
            //if (this.Count == 1)
            //{
            //    this._head = null;
            //    this._tail = null;
            //}
            //else
            //{
            //    this._head = this._head.Next;
            //}

            //this.Count--;
            //return temp.Item;
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
            this.ValidateIsEmpty();
            return this._head.Item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            Node<T> current = this._head;

            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private bool IsEmpty()
        {
            return this.Count == 0;
        }

        private void ValidateIsEmpty()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty!");
            }
        }
    }
}