namespace _02.LegionSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _02.LegionSystem.Interfaces;
    using Wintellect.PowerCollections;

    public class Legion : IArmy
    {

        OrderedSet<IEnemy> _legion;
        
        public Legion()
        {
            this._legion = new OrderedSet<IEnemy>();
        }

        public int Size => this._legion.Count;

        public void Create(IEnemy enemy)
        {
            //throw new NotImplementedException();
            this._legion.Add(enemy);
        }

        public bool Contains(IEnemy enemy)
        {
            //throw new NotImplementedException();
            return this._legion.Contains(enemy);
        }

        public IEnemy GetByAttackSpeed(int speed)
        {
            //throw new NotImplementedException();
            IEnemy result = null;

            for (int i = 0; i < this._legion.Count; i++)
            {
                IEnemy current = this._legion[i];

                if (current.AttackSpeed == speed)
                {
                    result = current;
                }
            }

            return result;
        }

        public List<IEnemy> GetFaster(int speed)
        {
            //throw new NotImplementedException();
            List<IEnemy> result = new List<IEnemy>();

            for (int i = 0; i < this._legion.Count; i++)
            {
                IEnemy current = this._legion[i];

                if (current.AttackSpeed > speed)
                {
                    result.Add(current);
                }
            }

            return result;
        }

        public IEnemy GetFastest()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            return this._legion[this.Size - 1];
        }

        public IEnemy[] GetOrderedByHealth()
        {
            //throw new NotImplementedException();
            IEnemy[] result = new IEnemy[this.Size];
            result = this._legion.OrderByDescending(e => e.Health).ToArray();
            return result;
        }

        public List<IEnemy> GetSlower(int speed)
        {
            //throw new NotImplementedException();
            List<IEnemy> result = new List<IEnemy>();

            for (int i = 0; i < this._legion.Count; i++)
            {
                IEnemy current = this._legion[i];

                if (current.AttackSpeed < speed)
                {
                    result.Add(current);
                }
            }
            
            return result;
        }

        public IEnemy GetSlowest()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            return this._legion[0];
        }

        public void ShootFastest()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            this._legion.RemoveLast();
        }

        public void ShootSlowest()
        {
            //throw new NotImplementedException();
            this.EnsureNotEmpty();
            this._legion.RemoveFirst();
        }

        private void EnsureNotEmpty()
        {
            if (this._legion.Count == 0)
            {
                throw new InvalidOperationException("Legion has no enemies!");
            }
        }
    }
}
