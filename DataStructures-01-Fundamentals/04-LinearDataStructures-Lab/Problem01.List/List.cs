namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] _items;

        /*public List()
            : this(DEFAULT_CAPACITY) {
        }*/

        public List(int capacity = DEFAULT_CAPACITY)
        {
            this.ValidateCapacity(capacity);
            this._items = new T[capacity];
            this.Capacity = this._items.Length;
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this._items[index];
            }
            set
            {
                this.ValidateIndex(index);
                this._items[index] = value;
            }
        }

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public void Add(T item)
        {
            this.GrowIfNeeded();
            this._items[Count] = item;
            this.Count++;
        }

        public bool Contains(T item)
        {
            //if (this.IndexOf(item) > -1)
            //{
            //    return true;
            //}
            //return false;
            return this.IndexOf(item) != -1;
        }


        public int IndexOf(T item)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Count; i++)
            {
                if (this._items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);
            GrowIfNeeded();

            for (int i = this.Count; i > index; i--)
            {
                this._items[i] = this._items[i - 1];
            }
            this._items[index] = item;

            this.Count++;
            //throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            //throw new NotImplementedException();
            //for (int i = 0; i < this.Count; i++)
            //{
            //    if (this._items[i].Equals(item))
            //    {
            //        //this._items[i] = default;
            //        //this.Count--;
            //        this.RemoveAt(i);
            //        return true;
            //    }
            //}
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
            for (int i = index; i < this.Count - 1; i++)
            {
                this._items[i] = this._items[i + 1];
            }

            this._items[this.Count - 1] = default;

            this.Count--;
            this.ShrinkIfNeeded();
        }

        public T[] ToArray()
        {
            T[] tempArray = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                tempArray[i] = this._items[i];
            }
            return tempArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Count; i++)
            {
                yield return this._items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //=> throw new NotImplementedException();
            return this.GetEnumerator();
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException($"{index} i not a valid value for index!");
            }
        }

        private void ValidateCapacity(int capacity)
        {
            if (capacity <= 0)
            {
                throw new IndexOutOfRangeException($"{capacity} i not a valid value for index!");
            }
        }

        private void GrowIfNeeded()
        {
            if (this.Count == this._items.Length)
            {
                this.Grow();
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
            this.Capacity = this._items.Length;
        }

        private void ShrinkIfNeeded()
        {
            if (this.Count * 2 < this._items.Length)
            {
                this.Shrink();
            }
        }

        private void Shrink()
        {
            T[] tempArr = new T[this._items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                tempArr[i] = this._items[i];
            }
            this._items = tempArr;
            this.Capacity = this._items.Length;
        }
    }
}