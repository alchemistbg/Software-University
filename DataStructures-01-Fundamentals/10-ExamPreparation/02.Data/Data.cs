namespace _02.Data
{
    using _02.Data.Interfaces;
    using _02.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using Wintellect.PowerCollections;

    public class Data : IRepository
    {

        OrderedBag<IEntity> _entities;

        public Data()
        {
            this._entities = new OrderedBag<IEntity>();
        }
        public Data(Data data)
        {
            this._entities = data._entities;
        }

        public int Size => this._entities.Count;

        public void Add(IEntity entity)
        {
            //throw new NotImplementedException();
            this._entities.Add(entity);

            IEntity parentNode = this.GetById((int)entity.ParentId);
            if (parentNode != null)
            {
                parentNode.Children.Add(entity);
            }
        }

        public IRepository Copy()
        {
            //throw new NotImplementedException();
            Data copy = (Data)this.MemberwiseClone();
            return new Data(copy);
        }

        public List<IEntity> GetAll()
        {
            //throw new NotImplementedException();
            return new List<IEntity>(this._entities);
        }

        public List<IEntity> GetAllByType(string type)
        {
            //throw new NotImplementedException();
            if (type != typeof(Invoice).Name
                && type != typeof(User).Name
                && type != typeof(StoreClient).Name)
            {
                throw new InvalidOperationException($"Invalid type: {type}");
            }

            List<IEntity> result = new List<IEntity>(this.Size);

            for (int i = 0; i < this.Size; i++)
            {
                IEntity current = this._entities[i];
                if (current.GetType().Name == type)
                {
                    result.Add(current);
                }
            }

            return result;
        }

        public IEntity GetById(int id)
        {
            //throw new NotImplementedException();
            if (id < 0 || id >= this.Size)
            {
                return null;
            }
            return this._entities[this.Size - 1 - id];
        }

        public List<IEntity> GetByParentId(int parentId)
        {
            //throw new NotImplementedException();
            List<IEntity> result = new List<IEntity>();

            IEntity parentNode = this.GetById(parentId);
            if (parentNode != null)
            {
                result = new List<IEntity>(parentNode.Children);
            }

            return result;
        }

        public IEntity PeekMostRecent()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            return this._entities.GetFirst();
        }

        public IEntity DequeueMostRecent()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            return this._entities.RemoveFirst();
        }

        private void EnsureNotEmpty()
        {
            if (this.Size == 0)
            {
                throw new InvalidOperationException("Operation on empty Data");
            }
        }
    }
}
