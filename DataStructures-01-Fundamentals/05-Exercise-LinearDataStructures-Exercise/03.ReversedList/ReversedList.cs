namespace Problem03.ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IAbstractList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _items;
        public int Count { get; private set; }

        public ReversedList()
        //: this(DefaultCapacity) { }
        {
            this._items = new T[DefaultCapacity];
        }

        public ReversedList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            this._items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                //throw new NotImplementedException();
                this.ValidateIndex(index);
                return this._items[this.NormalizeIndex(index)];
            }
            set
            {
                //throw new NotImplementedException();
                this.ValidateIndex(index);
                this.ShouldGrow();
                this._items[index] = value;
            }
        }

        public void Add(T item)
        {
            //throw new NotImplementedException();
            this.ShouldGrow();
            this._items[this.Count] = item;
            this.Count++;
        }

        public bool Contains(T item)
        {
            //throw new NotImplementedException();
            //for (int i = 0; i < this.Count; i++)
            //{
            //    if (this._items[i].Equals(item))
            //    {
            //        return true;
            //    }
            //}
            //return false;

            //Kiro solution
            return this.IndexOf(item) != -1; 
        }

        public int IndexOf(T item)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Count; i++)
            {
                if (this._items[i].Equals(item))
                {
                    return this.NormalizeIndex(i);
                }
            }

            //Kiro solution
            //for (int i = 1; i <= this.Count; i++)
            //{
            //    if (this._items[this.Count - i].Equals(item))
            //    {
            //        return i - 1;
            //    }
            //}

            //Solution form sli.do
            //for (int i = this.Count - 1; i >= 0; i--)
            //{
            //    if (this._items[i].Equals(item))
            //    {
            //        return this.Count - i - 1;
            //    }
            //}
            return -1;
        }

        public void Insert(int index, T item)
        {
            //throw new NotImplementedException();
            int normalizedIndex = this.Count - index;
            this.ValidateIndex(index);
            this.ShouldGrow();
            for (int i = this.Count; i > normalizedIndex; i--)
            {
                this._items[i] = this._items[i - 1];
            }
            this._items[normalizedIndex] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            //throw new NotImplementedException();
            int indexOfElement = this.IndexOf(item);
            if (indexOfElement == -1)
            {
                return false;
            }

            this.RemoveAt(indexOfElement);
            return true;
        }

        public void RemoveAt(int index)
        {
            //throw new NotImplementedException();
            this.ValidateIndex(index);

            int normalizedIndex = this.NormalizeIndex(index);

            //My original code
            //this._items[normalizedIndex] = default;
            //for (int i = normalizedIndex; i < this.Count; i++)
            //{
            //    this._items[i] = this._items[i + 1];
            //}

            //Kiro solution
            for (int i = normalizedIndex; i < this.Count - 1; i++)
            {
                this._items[i] = this._items[i + 1];
            }
            this._items[this.Count - 1] = default;
            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this._items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return this.GetEnumerator();
        }

        private void ValidateIndex(int index)
        {
            if (!IsIndexValid(index))
            {
                throw new IndexOutOfRangeException($"{index} i not a valid value for index!");
            }
        }

        private bool IsIndexValid(int index)
        {
            return (index >= 0 && index < this.Count);
        }

        private void ShouldGrow()
        {
            if (this.Count == this._items.Length)
            {
                Grow();
            }
        }

        private void Grow()
        {
            T[] tempArr = new T[this._items.Length * 2];
            for (int i = 0; i < this._items.Length; i++)
            {
                tempArr[i] = this._items[i];
            }
            this._items = tempArr;
        }

        private int NormalizeIndex(int indexToReverse)
        {
            return this.Count - indexToReverse - 1;
        }
    }
}