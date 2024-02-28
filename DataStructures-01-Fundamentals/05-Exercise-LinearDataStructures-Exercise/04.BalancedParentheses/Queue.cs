namespace Problem04.BalancedParentheses
{
    using System;

    public class Queue<T>
    {
        private Node<T> _head { get; set; }
        private Node<T> _tail { get; set; }
        public int Count { get; private set; }

        public Queue()
        {
            this._head = null;
            this.Count = 0;
        }
        public void Enqueue(T item)
        {
            Node<T> currentHead = this._head;
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

        public T Dequeue()
        {
            this.CheckIsEmpty();
            Node<T> tempNode = this._head;

            this._head.Next = this._head;
            this.Count--;
            return tempNode.Item;
        }

        private void CheckIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }
        }
        
    }
}