//namespace _01.BSTOperations
//{
//    using System;
//    using System.Collections.Generic;

//    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
//        where T : IComparable<T>
//    {
//        public BinarySearchTree()
//        {
//            this.Root = null;
//        }

//        public BinarySearchTree(T value)
//        {
//            this.Root.Value = value;
//        }

//        public BinarySearchTree(Node<T> root)
//        {
//            // TODO: Create copy from root
//            this.Copy(root);
//        }

//        public Node<T> Root { get; private set; }

//        public Node<T> LeftChild { get; private set; }

//        public Node<T> RightChild { get; private set; }

//        public T Value => this.Root.Value;

//        //public int Count => throw new NotImplementedException();
//        public int Count { get; private set; }

//        public bool Contains(T element)
//        {
//            //throw new NotImplementedException();
//            Node<T> currentNode = this.Root;

//            while (currentNode != null)
//            {
//                if (this.IsGreater(currentNode.Value, element))
//                {
//                    currentNode = currentNode.LeftChild;
//                }
//                else if(this.IsLess(currentNode.Value, element))
//                {
//                    currentNode = currentNode.RightChild;
//                }
//                else
//                {
//                    return true;
//                }
//            }

//            return false;
//        }

//        public void Insert(T element)
//        {
//            //throw new NotImplementedException();
//            Node<T> newNode = new Node<T>(element, null, null);

//            if (this.Root == null)
//            {
//                this.Root = newNode;
//                this.Count++;
//            }
//            else
//            {
//                Node<T> currentNode = this.Root;
//                Node<T> prev = null;

//                while (currentNode != null)
//                {
//                    prev = currentNode;
//                    if (this.IsGreater(currentNode.Value, newNode.Value))
//                    {
//                        currentNode = currentNode.LeftChild;
//                    }
//                    else if (this.IsLess(currentNode.Value, newNode.Value))
//                    {
//                        currentNode = currentNode.RightChild;
//                    }
//                    else
//                    {
//                        return;
//                    }
//                }

//                if (this.IsGreater(prev.Value, newNode.Value))
//                {
//                    prev.LeftChild = newNode;
//                    if (this.LeftChild == null)
//                    {
//                        this.LeftChild = newNode;
//                    }
//                }
//                else
//                {
//                    prev.RightChild = newNode;
//                    if (this.RightChild == null)
//                    {
//                        this.RightChild = newNode;
//                    }
//                }
//                this.Count++;
//            }
//        }

//        public IAbstractBinarySearchTree<T> Search(T element)
//        {
//            //throw new NotImplementedException();
//            Node<T> currentNode = this.Root;

//            while (currentNode != null && !this.AreEqual(currentNode.Value, element))
//            {
//                if (this.IsGreater(currentNode.Value, element))
//                {
//                    currentNode = currentNode.LeftChild;
//                }
//                else if (this.IsLess(currentNode.Value, element))
//                {
//                    currentNode = currentNode.RightChild;
//                }
//            }
//            return new BinarySearchTree<T>(currentNode);
//        }

//        public void EachInOrder(Action<T> action)
//        {
//            this.EachInOrderDFS(this.Root, action);
//        }

//        private void EachInOrderDFS(Node<T> currentNode, Action<T> action)
//        {
//            if (currentNode != null)
//            {
//                this.EachInOrderDFS(currentNode.LeftChild, action);
//                action.Invoke(currentNode.Value);
//                this.EachInOrderDFS(currentNode.RightChild, action);
//            }
//        }

//        public List<T> Range(T lower, T upper)
//        {
//            //throw new NotImplementedException();
//            List<T> result = new List<T>();

//            Queue<Node<T>> nodes = new Queue<Node<T>>();
//            nodes.Enqueue(this.Root);

//            while (nodes.Count > 0)
//            {
//                Node<T> currentNode = nodes.Dequeue();
//                if (this.IsGreater(currentNode.Value, lower) && this.IsLess(currentNode.Value, upper))
//                {
//                    result.Add(currentNode.Value);
//                }
//                else if (this.AreEqual(currentNode.Value, lower) || this.AreEqual(currentNode.Value, upper))
//                {
//                    result.Add(currentNode.Value);
//                }

//                if (currentNode.LeftChild != null)
//                {
//                    nodes.Enqueue(currentNode.LeftChild);
//                }

//                if (currentNode.RightChild != null)
//                {
//                    nodes.Enqueue(currentNode.RightChild);
//                }
//            }

//            return result;
//        }

//        public void DeleteMin()
//        {

//            //throw new NotImplementedException();
//            if (this.Count == 0)
//            {
//                throw new InvalidOperationException("The tree is empty!");
//            }

//            if (this.Count == 1)
//            {
//                this.Root = null;
//            }

//            Node<T> currentNode = this.Root;
//            Node<T> prev = null;

//            while (currentNode.LeftChild != null)
//            {
//                prev = currentNode;
//                currentNode = currentNode.LeftChild;
//            }

//            Node<T> temp = null;
//            if (prev.LeftChild.RightChild != null)
//            {
//                temp = prev.LeftChild.RightChild;
//                prev.LeftChild = temp;
//            }else
//            {
//                prev.LeftChild = null;
//            }
//            this.Count--;
//        }

//        public void DeleteMax()
//        {
//            //throw new NotImplementedException();
//            if (this.Count == 0)
//            {
//                throw new InvalidOperationException("The tree is empty!");
//            }

//            if (this.Count == 1)
//            {
//                this.Root = null;
//            }
//            Node<T> currentNode = this.Root;
//            Node<T> prev = null;
//            while (currentNode.RightChild != null)
//            {
//                prev = currentNode;
//                currentNode = currentNode.RightChild;
//            }

//            Node<T> temp = null;
//            if (prev.RightChild.LeftChild != null)
//            {
//                temp = prev.RightChild.LeftChild;
//                prev.RightChild = temp;
//            }
//            else
//            {
//                prev.RightChild = null;
//            }
//            this.Count--;
//        }

//        public int GetRank(T element)
//        {
//            //throw new NotImplementedException();
//            int result = 0;

//            Queue<Node<T>> nodes = new Queue<Node<T>>();
//            nodes.Enqueue(this.Root);

//            while (nodes.Count > 0)
//            {
//                Node<T> currentNode = nodes.Dequeue();
//                if (currentNode.Value.CompareTo(element) < 0)
//                {
//                    result++;
//                }

//                if (currentNode.LeftChild != null)
//                {
//                    nodes.Enqueue(currentNode.LeftChild);
//                }

//                if (currentNode.RightChild != null)
//                {
//                    nodes.Enqueue(currentNode.RightChild);
//                }
//            }

//            return result;
//        }        

//        private bool IsGreater(T value1, T value2)
//        {
//            return value1.CompareTo(value2) > 0;
//        }

//        private bool IsLess(T value1, T value2)
//        {
//            return value1.CompareTo(value2) < 0;
//        }

//        private bool AreEqual(T value1, T value2)
//        {
//            return value1.CompareTo(value2) == 0;
//        }

//        private void Copy(Node<T> root)
//        {
//            if (root != null)
//            {
//                this.Insert(root.Value);
//                this.Copy(root.LeftChild);
//                this.Copy(root.RightChild);
//            }
//        }
//    }
//}

namespace _01.BSTOperations
{
    using System;
    using System.Collections.Generic;

    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
        }

        public BinarySearchTree(Node<T> root)
        {
            this.Copy(root);
        }

        public Node<T> Root { get; private set; }

        public Node<T> LeftChild { get; private set; }

        public Node<T> RightChild { get; private set; }

        public T Value => this.Root.Value;

        public int Count => this.Root.Count;

        public bool Contains(T element)
        {
            Node<T> current = this.Root;

            while (current != null)
            {
                if (this.IsLess(element, current.Value))
                {
                    current = current.LeftChild;
                }
                else if (this.IsGreater(element, current.Value))
                {
                    current = current.RightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Insert(T element)
        {
            Node<T> toInsert = new Node<T>(element, null, null);

            if (this.Root == null)
            {
                this.Root = toInsert;
            }
            else
            {
                this.InsertElementDfs(this.Root, null, toInsert);
            }
        }

        public IAbstractBinarySearchTree<T> Search(T element)
        {
            Node<T> current = this.Root;

            while (current != null)
            {
                if (this.IsLess(element, current.Value))
                {
                    current = current.LeftChild;
                }
                else if (this.IsGreater(element, current.Value))
                {
                    current = current.RightChild;
                }
                else
                {
                    break;
                }
            }

            return new BinarySearchTree<T>(current);
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrderDfs(this.Root, action);
        }

        public List<T> Range(T lower, T upper)
        {
            var result = new List<T>();
            var nodes = new Queue<Node<T>>();

            nodes.Enqueue(this.Root);

            while (nodes.Count > 0)
            {
                var current = nodes.Dequeue();

                if (this.IsLess(lower, current.Value) && this.IsGreater(upper, current.Value))
                {
                    result.Add(current.Value);
                }
                else if (this.AreEqual(lower, current.Value) || this.AreEqual(upper, current.Value))
                {
                    result.Add(current.Value);
                }

                if (current.LeftChild != null)
                {
                    nodes.Enqueue(current.LeftChild);
                }

                if (current.RightChild != null)
                {
                    nodes.Enqueue(current.RightChild);
                }
            }

            return result;
        }

        public void DeleteMin()
        {
            this.EnsureNotEmpty();

            Node<T> current = this.Root;
            Node<T> previous = null;

            if (this.Root.LeftChild == null)
            {
                this.Root = this.Root.RightChild;
            }
            else
            {
                while (current.LeftChild != null)
                {
                    current.Count--;
                    previous = current;
                    current = current.LeftChild;
                }

                previous.LeftChild = current.RightChild;
            }
        }

        public void DeleteMax()
        {
            this.EnsureNotEmpty();

            Node<T> current = this.Root;
            Node<T> previous = null;

            if (this.Root.RightChild == null)
            {
                this.Root = this.Root.LeftChild;
            }
            else
            {
                while (current.RightChild != null)
                {
                    current.Count--;
                    previous = current;
                    current = current.RightChild;
                }

                previous.RightChild = current.LeftChild;
            }
        }

        public int GetRank(T element)
        {
            return this.GetRankDfs(this.Root, element);
        }

        private void InsertElementDfs(Node<T> current, Node<T> previous, Node<T> toInsert)
        {
            if (current == null && this.IsLess(toInsert.Value, previous.Value))
            {
                previous.LeftChild = toInsert;

                if (this.LeftChild == null)
                {
                    this.LeftChild = toInsert;
                }
                return;
            }

            if (current == null && this.IsGreater(toInsert.Value, previous.Value))
            {
                previous.RightChild = toInsert;

                if (this.RightChild == null)
                {
                    this.RightChild = toInsert;
                }
                return;
            }

            if (this.IsLess(toInsert.Value, current.Value))
            {
                this.InsertElementDfs(current.LeftChild, current, toInsert);
                current.Count++;
            }
            else if (this.IsGreater(toInsert.Value, current.Value))
            {
                this.InsertElementDfs(current.RightChild, current, toInsert);
                current.Count++;
            }
        }

        private bool IsLess(T firstEl, T secondEl)
        {
            return firstEl.CompareTo(secondEl) < 0;
        }

        private bool IsGreater(T firstEl, T secondEl)
        {
            return firstEl.CompareTo(secondEl) > 0;
        }

        private bool AreEqual(T firstEl, T secondEl)
        {
            return firstEl.CompareTo(secondEl) == 0;
        }

        private void EachInOrderDfs(Node<T> current, Action<T> action)
        {
            if (current != null)
            {
                this.EachInOrderDfs(current.LeftChild, action);
                action.Invoke(current.Value);
                this.EachInOrderDfs(current.RightChild, action);
            }
        }

        private void Copy(Node<T> current)
        {
            if (current != null)
            {
                this.Insert(current.Value);
                this.Copy(current.LeftChild);
                this.Copy(current.RightChild);
            }
        }

        private void EnsureNotEmpty()
        {
            if (this.Root == null)
            {
                throw new InvalidOperationException("BST is empty!");
            }
        }

        private int GetRankDfs(Node<T> current, T element)
        {
            if (current == null)
            {
                return 0;
            }

            if (this.IsLess(element, current.Value))
            {
                return this.GetRankDfs(current.LeftChild, element);
            }
            else if (this.AreEqual(element, current.Value))
            {
                return this.GetNodeCount(current);
            }

            return this.GetNodeCount(current.LeftChild) + 1 + this.GetRankDfs(current.RightChild, element);
        }

        private int GetNodeCount(Node<T> current)
        {
            return current == null ? 0 : current.Count;
        }
    }
}
