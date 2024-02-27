namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        public SinglyLinkedList()
        {

        }

        public void AddFirst(T item)
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
                newNode.Next = this._head;
                this._head = newNode;
            }
            this.Count++;
        }

        public void AddLast(T item)
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

        public T GetFirst()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            return this._head.Value;
        }

        public T GetLast()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            return this._tail.Value;
        }

        public T RemoveFirst()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            Node<T> tempNode = this._head;
            this._head = this._head.Next;
            this.Count--;
            return tempNode.Value;
        }

        public T RemoveLast()
        {
            //throw new NotImplementedException();
            this.CheckIsEmpty();
            Node<T> tempNode = this._tail;
            Node<T> currentNode = this._head;

            while (currentNode.Next != null)
            {
                if (currentNode.Next == this._tail)
                {
                    currentNode.Next = null;
                    this._tail = currentNode;
                }
                currentNode = currentNode.Next;
            }

            this.Count--;
            return tempNode.Value;
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
        //=> this.GetEnumerator();
        {
            return this.GetEnumerator();
        }

        private void CheckIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
        }
    }
}