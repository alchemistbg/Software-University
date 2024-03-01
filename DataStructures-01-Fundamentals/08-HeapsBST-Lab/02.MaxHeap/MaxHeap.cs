namespace _02.MaxHeap
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;

    public class MaxHeap<T> : IAbstractHeap<T>
        where T : IComparable<T>
    {
        private List<T> _heap = new List<T>();
      
        //public int Size { get; private set; }
        public int Size => this._heap.Count;

        public void Add(T element)
        {
            //throw new NotImplementedException();
            this._heap.Add(element);
            this.HeapifyUp(this._heap.Count - 1);
            //Incrementing the size is not neccessery
            //this.Size++;
        }

        private int GetLastNonLeafNodeIndex()
        {
            return (this.Size / 2 - 1);
        }

        private int GetParentIndex(int childIndex)
        {
            return (childIndex - 1)/2;
        }

        private int GetLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int GetRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        private bool IsChildGreater(int childIndex, int parentIndex)
        {
            return this._heap[childIndex].CompareTo(this._heap[parentIndex]) > 0;
        }

        private void HeapifyUp(int indexToHeapifyUp)
        {
            int parentIndex = this.GetParentIndex(indexToHeapifyUp);

            while (indexToHeapifyUp > 0 && this.IsChildGreater(indexToHeapifyUp, parentIndex))
            {
                this.Swap(indexToHeapifyUp, parentIndex);
                indexToHeapifyUp = parentIndex;
                parentIndex = this.GetParentIndex(indexToHeapifyUp);
            }
        }

        private void Swap(int indexToHeapifyUp, int parentIndex)
        {
            //throw new NotImplementedException();
            T temp = this._heap[indexToHeapifyUp];
            this._heap[indexToHeapifyUp] = this._heap[parentIndex];
            this._heap[parentIndex] = temp;
        }

        public T Peek()
        {
            //throw new NotImplementedException();
            if (this.IsHeapEmpty())
            {
                throw new InvalidOperationException("The heap is empty!");
            }

            return this._heap[0];
        }

        private bool IsHeapEmpty()
        {
            return this.Size == 0;
        }
    }
}
