using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Loader
{
    public class Node<IEntity>
    {
        public IEntity Value { get; set; }

        public Node<IEntity> Next { get; set; }

        public Node<IEntity> Prev { get; set; }

        public Node(IEntity value, Node<IEntity> next = null, Node<IEntity> prev = null)
        {
            this.Value = value;
            this.Next = next;
            this.Prev = prev;
        }
    }
}

