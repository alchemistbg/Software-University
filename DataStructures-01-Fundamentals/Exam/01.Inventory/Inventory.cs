namespace _01.Inventory
{
    using _01.Inventory.Interfaces;
    using _01.Inventory.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;

    public class Inventory : IHolder
    {
        public int Capacity => this._inventory.Count;

        private List<IWeapon> _inventory;

        //public Inventory(int capacity)
        //{
        //    //this.ValidateCapacity(capacity);
        //    //this._items = new T[capacity];
        //    //this.Capacity = this._items.Length;
        //    this._inventory = new List<IHolder>(capacity);
        //}

        public Inventory()
        {
            this._inventory = new List<IWeapon>();
        }

        public void Add(IWeapon weapon)
        {
            //throw new NotImplementedException();
            this._inventory.Add(weapon);
        }

        public void Clear()
        {
            //throw new NotImplementedException();
            this._inventory.Clear();
        }

        public bool Contains(IWeapon weapon)
        {
            //throw new NotImplementedException();
            return this.GetWeaponById(weapon.Id) != null;
        }

        public void EmptyArsenal(Category category)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this.Capacity; i++)
            {
                IWeapon current = this._inventory[i];

                if (current.Category.Equals(category))
                {
                    current.Ammunition = 0;
                }
            }
        }

        public bool Fire(IWeapon weapon, int ammunition)
        {
            //throw new NotImplementedException();
            IWeapon toFire = this.GetById(weapon.Id);

            if (toFire == null)
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }

            if (toFire.Ammunition >= ammunition)
            {
                toFire.Ammunition -= ammunition;
                return true;
            }

            return false;
        }

        public IWeapon GetById(int id)
        {
            //throw new NotImplementedException();
            return this.GetWeaponById(id);
        }

        public int Refill(IWeapon weapon, int ammunition)
        {
            //throw new NotImplementedException();
            IWeapon toRefill = this.GetById(weapon.Id);
            if (toRefill == null)
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }

            if (toRefill.Ammunition + ammunition >= toRefill.MaxCapacity)
            {
                toRefill.Ammunition = toRefill.MaxCapacity;
            }
            else
            {
                toRefill.Ammunition += ammunition;
            }

            return toRefill.Ammunition;
        }

        public IWeapon RemoveById(int id)
        {
            //throw new NotImplementedException();
            IWeapon toRemove = this.GetById(id);
            if (toRemove == null)
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }
            this._inventory.Remove(toRemove);
            return toRemove;
        }

        public int RemoveHeavy()
        {
            //throw new NotImplementedException();
            return this._inventory.RemoveAll(w => w.Category == Category.Heavy);
        }

        public List<IWeapon> RetrieveAll()
        {
            //throw new NotImplementedException();
            //return this._inventory;
            List<IWeapon> weapons = new List<IWeapon>(this._inventory);
            return weapons;
        }

        public List<IWeapon> RetriveInRange(Category lower, Category upper)
        {
            //throw new NotImplementedException();
            List<IWeapon> result = new List<IWeapon>();

            for (int i = 0; i < this._inventory.Count; i++)
            {
                IWeapon current = this._inventory[i];

                if (current.Category >= lower && current.Category <= upper)
                {
                    result.Add(current);
                }
            }

            return result;
        }

        public void Swap(IWeapon firstWeapon, IWeapon secondWeapon)
        {
            //throw new NotImplementedException();
            if (firstWeapon.Category != secondWeapon.Category)
            {
                return;
            }

            int firstWeaponIndex = this.GetWeaponIndex(firstWeapon);
            if (firstWeaponIndex < 0)
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }

            int secondWeaponIndex = this.GetWeaponIndex(secondWeapon);
            if (secondWeaponIndex < 0)
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }

            IWeapon temp = this._inventory[firstWeaponIndex];
            this._inventory[firstWeaponIndex] = this._inventory[secondWeaponIndex];
            this._inventory[secondWeaponIndex] = temp;
        }

        public IEnumerator<IWeapon> GetEnumerator()
        {
            //throw new NotImplementedException();
            for (int i = 0; i < this._inventory.Count; i++)
            {
                yield return this._inventory[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return this.GetEnumerator();
        }

        private IWeapon GetWeaponById(int Id)
        {
            for (int i = 0; i < this.Capacity; i++)
            {
                IWeapon current = this._inventory[i];

                if (current.Id == Id)
                {
                    return current;
                }
            }

            return null;
        }

        private int GetWeaponIndex(IWeapon weapon)
        {
            return this._inventory.IndexOf(weapon);
        }
    }
}
