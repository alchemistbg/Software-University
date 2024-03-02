namespace _01.Loader
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Loader : IBuffer
    {
        private List<IEntity> _entities;
        public int EntitiesCount => this._entities.Count;

        public Loader()
        {
            this._entities = new List<IEntity>();
        }

        public void Add(IEntity entity)
        {
            this._entities.Add(entity);
        }

        public void Clear()
        {
            this._entities.Clear();
        }

        public bool Contains(IEntity entity)
        {
            return this.Find(entity) != null;
        }

        public IEntity Extract(int id)
        {
            IEntity result = null;
            int index = this.GetEntityIndex(id);

            if (index > -1)
            {
                result = this._entities[index];
                this._entities.RemoveAt(index);
            }

            return result;
        }

        public IEntity Find(IEntity entity)
        {
            int index = this.GetEntityIndex(entity);
            return index > -1 ? this._entities[index] : null;
        }

        public List<IEntity> GetAll()
        {
            return this._entities;
        }

        public void RemoveSold()
        {
            this._entities.RemoveAll(e => e.Status == BaseEntityStatus.Sold);
        }

        public void Replace(IEntity oldEntity, IEntity newEntity)
        {
            int index = this.GetEntityIndex(oldEntity);

            if (index < 0)
            {
                throw new InvalidOperationException("Entity not found");
            }

            this._entities[index] = newEntity;
        }

        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
        {
            List<IEntity> result = new List<IEntity>();
            for (int i = 0; i < this.EntitiesCount; i++)
            {
                if (this._entities[i].Status >= lowerBound && this._entities[i].Status <= upperBound)
                {
                    result.Add(this._entities[i]);
                }
            }
            return result;
        }

        public void Swap(IEntity first, IEntity second)
        {
            int indexFirst = this.GetEntityIndex(first.Id);
            int indexSecond = this.GetEntityIndex(second.Id);

            if (indexFirst < 0 && indexSecond < 0)
            {
                throw new InvalidOperationException("Entity not found");
            }

            IEntity temp = this._entities[indexFirst];
            this._entities[indexFirst] = this._entities[indexSecond];
            this._entities[indexSecond] = temp;
        }

        public IEntity[] ToArray()
        {
            return this._entities.ToArray();
        }

        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
        {
            for (int i = 0; i < this.EntitiesCount; i++)
            {
                if (this._entities[i].Status.Equals(oldStatus))
                {
                    this._entities[i].Status = newStatus;
                }
            }
        }

        public IEnumerator<IEntity> GetEnumerator()
        {
            for (int i = 0; i < this.EntitiesCount; i++)
            {
                yield return this._entities[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int GetEntityIndex(IEntity entity)
        {
            for (int i = 0; i < this.EntitiesCount; i++)
            {
                if (this._entities[i].Equals(entity))
                {
                    return i;
                }
            }

            //throw new InvalidOperationException("Entity not found");
            return -1;
        }

        private int GetEntityIndex(int entityId)
        {
            for (int i = 0; i < this.EntitiesCount; i++)
            {
                if (this._entities[i].Id == entityId)
                {
                    return i;
                }
            }

            //throw new InvalidOperationException("Entity not found");
            return -1;
        }
    }
}

//namespace _01.Loader
//{
//    using _01.Loader.Interfaces;
//    using _01.Loader.Models;
//    using System;
//    using System.Collections;
//    using System.Collections.Generic;

//    public class Loader : IBuffer
//    {
//        private Node<IEntity> _head;
//        private Node<IEntity> _tail;

//        //public int EntitiesCount => throw new NotImplementedException();
//        public int EntitiesCount { get; private set; }

//        public Loader()
//        {
//            this._head = null;
//            this._tail = null;
//            this.EntitiesCount = 0;
//        }

//        public void Add(IEntity entity)
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> newEntity = new Node<IEntity>(entity);

//            if (this.EntitiesCount == 0)
//            {
//                this._head = this._tail = newEntity;
//                this._head.Next = this._tail.Prev = null;
//            }
//            else
//            {
//                newEntity.Prev = this._tail;
//                this._tail.Next = newEntity;
//                this._tail = newEntity;
//            }

//            this.EntitiesCount++;
//        }

//        public void Clear()
//        {
//            //throw new NotImplementedException();\
//            this.EntitiesCount = 0;
//            this._head = this._tail = null;
//        }

//        public bool Contains(IEntity entity)
//        {
//            //throw new NotImplementedException();
//            //Node<IEntity> queryNode = new Node<IEntity>(entity);
//            //Node<IEntity> currentNode = this._head;

//            //while (currentNode != null)
//            //{
//            //    if (currentNode.Value.Equals(queryNode.Value))
//            //    {
//            //        return true;
//            //    }
//            //    currentNode = currentNode.Next;
//            //}
//            //return false;
//            return this.Find(entity) != null;
//        }

//        public IEntity Extract(int id)
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> currentNode = this._head;
//            while (currentNode != null)
//            {
//                if (currentNode.Value.Id == id)
//                {
//                    Node<IEntity> resultNode = currentNode;
//                    currentNode.Prev.Next = currentNode.Next;
//                    this.EntitiesCount--;
//                    return resultNode.Value;
//                }
//                currentNode = currentNode.Next;
//            }
//            return null;
//        }

//        public IEntity Find(IEntity entity)
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> queryNode = new Node<IEntity>(entity);
//            if (this.EntitiesCount > 0)
//            {
//                Node<IEntity> currentNode = this._head;
//                while (currentNode != null)
//                {
//                    if (currentNode.Value.Id == entity.Id)
//                    {
//                        return currentNode.Value;
//                    }
//                    currentNode = currentNode.Next;
//                }
//            }
//            return null;
//        }

//        public List<IEntity> GetAll()
//        {
//            //throw new NotImplementedException();
//            List<IEntity> result = new List<IEntity>();

//            Node<IEntity> currentNode = this._head;
//            while (currentNode != null)
//            {
//                result.Add(currentNode.Value);
//                currentNode = currentNode.Next;
//            }

//            return result;
//        }

//        public void RemoveSold()
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> currentNode = this._head;
//            while (currentNode != null)
//            {
//                if (currentNode.Value.Status.Equals(BaseEntityStatus.Sold))
//                {
//                    this.Extract(currentNode.Value.Id);
//                }
//                currentNode = currentNode.Next;
//            }
//        }

//        public void Replace(IEntity oldEntity, IEntity newEntity)
//        {
//            //throw new NotImplementedException();
//            //Node<IEntity> oldNode = new Node<IEntity>(this.Find(oldEntity));

//            if (this.Contains(oldEntity))
//            {
//                Node<IEntity> currentNode = this._head;
//                while (currentNode != null)
//                {
//                    if (currentNode.Value.Equals(oldEntity))
//                    {
//                        currentNode.Value = newEntity;
//                    }
//                    currentNode = currentNode.Next;
//                }
//            }
//            else
//            {
//                throw new InvalidOperationException("Entity not found");
//            }
//        }

//        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
//        {
//            //throw new NotImplementedException();
//            List<IEntity> result = new List<IEntity>();

//            Node<IEntity> currentNode = this._head;

//            while (currentNode != null)
//            {
//                if (currentNode.Value.Status >= lowerBound && currentNode.Value.Status <= upperBound)
//                {
//                    result.Add(currentNode.Value);
//                }
//                currentNode = currentNode.Next;
//            }

//            return result;
//        }

//        public void Swap(IEntity first, IEntity second)
//        {
//            //throw new NotImplementedException();
//            //IEntity firstEntity = this.Find(first);
//            //IEntity secondsEntity = this.Find(second);
//            //if (!this.Contains(first) && !this.Contains(second))
//            //{
//            //    throw new InvalidOperationException("Entity not found");
//            //}

//            this.Replace(this.Find(first), second);
//            this.Replace(this.Find(second), first);
//        }

//        public IEntity[] ToArray()
//        {
//            //throw new NotImplementedException();
//            List<IEntity> entities = this.GetAll();
//            IEntity[] result = new IEntity[this.EntitiesCount];

//            for (int i = 0; i < entities.Count; i++)
//            {
//                result[i] = entities[i];
//            }

//            return result;
//        }

//        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> currentNode = this._head;

//            while (currentNode != null)
//            {
//                if (currentNode.Value.Status.Equals(oldStatus))
//                {
//                    currentNode.Value.Status = newStatus;
//                }
//                currentNode = currentNode.Next;
//            }
//        }
//        public IEnumerator<IEntity> GetEnumerator()
//        {
//            //throw new NotImplementedException();
//            Node<IEntity> currentNode = this._head;

//            while (currentNode != null)
//            {
//                yield return currentNode.Value;
//                currentNode = currentNode.Next;
//            }
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            //throw new NotImplementedException();
//            return this.GetEnumerator();
//        }
//    }
//}
