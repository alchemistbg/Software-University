namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] _items;

        public List()
            : this(DEFAULT_CAPACITY) {
        }

        public List(int capacity)
        {
            //throw new NotImplementedException();
            this.ValidateCapacity(capacity);
            this._items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                //throw new NotImplementedException();
                this.ValidateIndex(index);
                return this._items[index];
            }
            set
            {
                //throw new NotImplementedException();
                this.ValidateIndex(index);
                this._items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            //throw new NotImplementedException();
            this.DoubleArrayLength();
            this._items[this.Count] = item;
            this.Count++;
        }

        public bool Contains(T item)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Count; i++)
            {
                if (this._items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
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
            //throw new NotImplementedException();
            this.ValidateIndex(index);
            this.IncreaseArrayLength(index);
            this._items[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Count; i++)
            {
                if (this._items[i].Equals(item))
                {
                    this._items[i] = default;
                    this.ReduceArrayLength(i);
                    this.Count--;
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            //throw new NotImplementedException();
            this.ValidateIndex(index);
            this._items[index] = default;
            this.ReduceArrayLength(index);
            this.Count--;
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
        //=> throw new NotImplementedException();
        {
            return this.GetEnumerator();
        }

        private void ValidateCapacity(int capacity)
        {
            //throw new NotImplementedException();
            if (capacity < 0)
            {
                throw new IndexOutOfRangeException($"Invalid cpacity: {capacity}");
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > this.Count - 1)
            {
                throw new IndexOutOfRangeException($"Ivdalid index: {index}");
            }
        }

        private void DoubleArrayLength()
        {
            if (ShouldDoubleArrayLength())
            {
                T[] temp = new T[_items.Length * 2];
                for (int i = 0; i < _items.Length; i++)
                {
                    temp[i] = _items[i];
                }
                _items = temp;
            }
        }

        private bool ShouldDoubleArrayLength()
        {
            return _items.Length == this.Count;
        }

        private void ReduceArrayLength(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this._items[i] = this._items[i + 1];
            }
            this._items[Count - 1] = default;
        }

        private void IncreaseArrayLength(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this._items[i] = this._items[i - 1];
            }
        }
    }
}