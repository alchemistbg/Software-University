namespace _01.Loader
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Loader : IBuffer
    {
        public List<IEntity> _entities;
        public Loader()
        {
            this._entities = new List<IEntity>();
        }
        public int EntitiesCount => this._entities.Count;

        public void Add(IEntity entity)
        {
            //throw new NotImplementedException();
            this._entities.Add(entity);
        }

        public void Clear()
        {
            //throw new NotImplementedException();
            this._entities.Clear();
        }

        public bool Contains(IEntity entity)
        {
            //throw new NotImplementedException();
            return this.GetById(entity.Id) != null;
        }

        public IEntity Extract(int id)
        {
            //throw new NotImplementedException();
            IEntity result = this.GetById(id);

            if (result != null)
            {
                this._entities.Remove(result);
            }

            return result;
        }

        public IEntity Find(IEntity entity)
        {
            //throw new NotImplementedException();
            return this.GetById(entity.Id);
        }

        public List<IEntity> GetAll()
        {
            //throw new NotImplementedException();
            return new List<IEntity>(this._entities);
        }

        public void RemoveSold()
        {
            //throw new NotImplementedException();
            this._entities.RemoveAll(e => e.Status == BaseEntityStatus.Sold);
        }

        public void Replace(IEntity oldEntity, IEntity newEntity)
        {
            //throw new NotImplementedException();
            int oldEntityIndex = this.GetEntityIndex(oldEntity);

            this.ValidateEntityByIndex(oldEntityIndex);

            this._entities[oldEntityIndex] = newEntity;
        }

        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
        {
            //throw new NotImplementedException();
            List<IEntity> result = new List<IEntity>(this.EntitiesCount);

            int lowerBoundInt = (int)lowerBound;
            int upperBoundInt = (int)upperBound;

            for (int i = 0; i < this.EntitiesCount; i++)
            {
                IEntity current = this._entities[i];
                int currentStatusInt = (int)current.Status;
                if (currentStatusInt >= lowerBoundInt
                    && currentStatusInt <= upperBoundInt)
                {
                    result.Add(current);
                }
            }

            return result;
        }

        public void Swap(IEntity first, IEntity second)
        {
            //throw new NotImplementedException();
            int firstEntityIndex = this.GetEntityIndex(first);
            this.ValidateEntityByIndex(firstEntityIndex);

            int secondEntityIndex = this.GetEntityIndex(second);
            this.ValidateEntityByIndex(secondEntityIndex);

            IEntity temp = this._entities[firstEntityIndex];
            this._entities[firstEntityIndex] = this._entities[secondEntityIndex];
            this._entities[secondEntityIndex] = temp;
        }

        public IEntity[] ToArray()
        {
            //throw new NotImplementedException();
            return this._entities.ToArray();
        }

        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this._entities.Count; i++)
            {
                IEntity current = this._entities[i];

                if (current.Status == oldStatus)
                {
                    current.Status = newStatus;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return this.GetEnumerator();
        }

        public IEnumerator<IEntity> GetEnumerator()
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this._entities.Count; i++)
            {
                yield return this._entities[i];
            }
        }

        private IEntity GetById(int Id)
        {
            for (int i = 0; i < this._entities.Count; i++)
            {
                IEntity current = this._entities[i];
                if (current.Id == Id)
                {
                    return current;
                }
            }

            return null;
        }

        private int GetEntityIndex(IEntity entity)
        {
            return this._entities.IndexOf(entity);
        }

        private void ValidateEntityByIndex(int index)
        {
            //throw new NotImplementedException();
            if (index < 0)
            {
                throw new InvalidOperationException("Error!");
            }
        }
    }
}
