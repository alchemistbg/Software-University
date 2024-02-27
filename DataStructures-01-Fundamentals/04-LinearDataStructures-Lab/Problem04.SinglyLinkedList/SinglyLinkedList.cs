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
            this._head = null;
            this._tail = null;
            this.Count = 0;
        }

        public void AddFirst(T item)
        {
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(item);

            if (this.IsEmpty())
            {
                this.InitializeList(newNode);
            }
            else
            {
                Node<T> temp = this._head;

                this._head = newNode;
                this._head.Next = temp;

            }
            this.Count++;
        }

        public void AddLast(T item)
        {
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(item);

            if (this.IsEmpty())
            {
                this.InitializeList(newNode);
            }
            else
            {
                Node<T> temp = this._tail;

                this._tail.Next = newNode;
                this._tail = newNode;
            }
            this.Count++;
        }

        public T GetFirst()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            return this._head.Value;
        }

        public T GetLast()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();
            return this._tail.Value;
        }

        public T RemoveFirst()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();

            Node<T> tempNode = this._head;
            this._head = tempNode.Next;
            this.Count--;
            return tempNode.Value;
        }

        public T RemoveLast()
        {
            //throw new NotImplementedException();
            this.ValidateIsEmpty();

            Node<T> temp = this._tail;
            Node<T> currentNode = this._head;

            while (currentNode != null)
            {
                if (currentNode.Next == this._tail)
                {
                    currentNode.Next = null;
                    this._tail = currentNode;
                }
                currentNode = currentNode.Next;
            }

            this.Count--;
            return temp.Value;

            //Node<T> currentNode = this._head;
            //Node<T> last = null;

            //if (currentNode.Next == null)
            //{
            //    last = this._head;
            //    this._head = null;
            //}
            //else
            //{
            //    while (currentNode != null)
            //    {
            //        if (currentNode.Next.Next == null)
            //        {
            //            last = currentNode.Next;
            //            currentNode.Next = null;
            //            break;
            //        }
            //        currentNode = currentNode.Next;
            //    }
            //}

            //this.Count--;
            //return last.Value;
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
        {
            //=> this.GetEnumerator();
            return this.GetEnumerator();
        }

        private void InitializeList(Node<T> newNode)
        {
            this._head = newNode;
            this._tail = newNode;
        }

        private void ValidateIsEmpty()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("The list is empty!");
            }
        }

        private bool IsEmpty()
        {
            return this.Count == 0;
        }
    }
}