namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            this._head = null;
            this._tail = null;
            this.Count = 0; 
        }

        public void AddFirst(T item)
        {
            //throw new NotImplementedException();
            Node<T> NewNode = new Node<T>(item);
            if (this.IsEmpty())
            {
                this.AddIfListIsEmpty(NewNode);
            }
            else
            {
                NewNode.Next = this._head;
                this._head.Prev = NewNode;
                this._head = NewNode;
            }
            this.Count++;
        }

        public void AddLast(T item)
        {
            //throw new NotImplementedException();
            Node<T> NewNode = new Node<T>(item);
            if (IsEmpty())
            {
                this.AddIfListIsEmpty(NewNode);
            }
            else
            {
                NewNode.Prev = this._tail;
                this._tail.Next = NewNode;
                this._tail = NewNode;
            }
            this.Count++;
        }

        public T GetFirst()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            return this._head.Item;
        }

        public T GetLast()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            return this._tail.Item;
        }

        public T RemoveFirst()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            Node<T> TempNode = this._head;
            if (this.Count > 1)
            {
                this._head = this._head.Next;
                this._head.Prev = null;
            }
            else
            {
                this.RemoveIfListIsEmpty();
            }
            this.Count--;
            return TempNode.Item;
        }

        public T RemoveLast()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            Node<T> TempNode = this._tail;
            if (this.Count > 1)
            {
                this._tail = this._tail.Prev;
                this._tail.Next = null;
            }
            else
            {
                this.RemoveIfListIsEmpty();
            }
            this.Count--;
            return TempNode.Item;
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
            //throw new NotImplementedException();
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
                throw new InvalidOperationException("The list is empty");
            }
        }

        private void AddIfListIsEmpty(Node<T> NewNode)
        {
            this._head = NewNode;
            this._tail = NewNode;
        }

        private void RemoveIfListIsEmpty()
        {
            this._head = null;
            this._tail = null;
        }
    }
}