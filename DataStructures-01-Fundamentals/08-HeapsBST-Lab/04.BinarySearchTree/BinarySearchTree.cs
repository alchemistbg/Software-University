namespace _04.BinarySearchTree
{
    using System;

    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            this.Root = null;
        }

        public BinarySearchTree(T value)
        {
            this.Root.Value = value;
        }

        public BinarySearchTree(Node<T> root)
        {
            // TODO: Create copy from root
            this.Copy(root);
        }

        public Node<T> Root { get; private set; }

        public Node<T> LeftChild { get; private set; }

        public Node<T> RightChild { get; private set; }

        public T Value => this.Root.Value;

        public bool Contains(T element)
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this.Root;

            while (currentNode != null)
            {
                if (this.IsSmaller(currentNode.Value, element))
                {
                    currentNode = currentNode.RightChild;
                }
                else if (this.IsGreater(currentNode.Value, element))
                {
                    currentNode = currentNode.LeftChild;
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
            //throw new NotImplementedException();
            Node<T> newNode = new Node<T>(element, null, null);

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                Node<T> currentNode = this.Root;
                Node<T> prevNode = null;

                while (currentNode != null)
                {
                    prevNode = currentNode;
                    if (this.IsSmaller(element, currentNode.Value))
                    {
                        currentNode = currentNode.LeftChild;
                    }
                    else if (this.IsGreater(element, currentNode.Value))
                    {
                        currentNode = currentNode.RightChild;
                    }
                    else
                    {
                        return;
                    }
                }

                if (this.IsSmaller(element, prevNode.Value))
                {
                    prevNode.LeftChild = newNode;
                    if (this.LeftChild == null)
                    {
                        this.LeftChild = newNode;
                    }
                }
                else
                {
                    prevNode.RightChild = newNode;
                    if (this.RightChild == null)
                    {
                        this.RightChild = newNode;
                    }
                }
            }
        }

        private bool IsGreater(T value1, T value2)
        {
            return value1.CompareTo(value2) > 0;
        }

        private bool IsSmaller(T value1, T value2)
        {
            return value1.CompareTo(value2) < 0;
        }

        private bool IsEqual(T value1, T value2)
        {
            return value1.CompareTo(value2) == 0;
        }

        public IAbstractBinarySearchTree<T> Search(T element)
        {
            //throw new NotImplementedException();
            Node<T> currentNode = this.Root;

            while (currentNode != null && !this.IsEqual(element, currentNode.Value))
            {
                if (this.IsSmaller(currentNode.Value, element))
                {
                    currentNode = currentNode.RightChild;
                }
                else if (this.IsGreater(currentNode.Value, element))
                {
                    currentNode = currentNode.LeftChild;
                }
            }

            return new BinarySearchTree<T>(currentNode);
        }


        private void Copy(Node<T> node)
        {
            if (node != null)
            {
                this.Insert(node.Value);
                this.Copy(node.LeftChild);
                this.Copy(node.RightChild);
            }
        }
    }
}

//namespace _04.BinarySearchTree
//{
//    using System;

//    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
//        where T : IComparable<T>
//    {
//        public BinarySearchTree()
//        {
//        }

//        public BinarySearchTree(Node<T> root)
//        {
//            this.Copy(root);
//        }

//        public Node<T> Root { get; private set; }

//        public Node<T> LeftChild { get; private set; }

//        public Node<T> RightChild { get; private set; }

//        public T Value => this.Root.Value;

//        public bool Contains(T element)
//        {
//            var current = this.Root;

//            while (current != null)
//            {
//                if (this.IsLess(element, current.Value))
//                {
//                    current = current.LeftChild;
//                }
//                else if (this.IsGreater(element, current.Value))
//                {
//                    current = current.RightChild;
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
//            var toInsert = new Node<T>(element, null, null);

//            if (this.Root == null)
//            {
//                this.Root = toInsert;
//            }
//            else
//            {
//                var current = this.Root;
//                Node<T> prev = null;

//                while (current != null)
//                {
//                    prev = current;

//                    if (this.IsLess(element, current.Value))
//                    {
//                        current = current.LeftChild;
//                    }
//                    else if (this.IsGreater(element, current.Value))
//                    {
//                        current = current.RightChild;
//                    }
//                    else
//                    {
//                        return;
//                    }
//                }

//                if (this.IsLess(element, prev.Value))
//                {
//                    prev.LeftChild = toInsert;

//                    if (this.LeftChild == null)
//                    {
//                        this.LeftChild = toInsert;
//                    }
//                }
//                else
//                {
//                    prev.RightChild = toInsert;

//                    if (this.RightChild == null)
//                    {
//                        this.RightChild = toInsert;
//                    }
//                }
//            }
//        }

//        public IAbstractBinarySearchTree<T> Search(T element)
//        {
//            var current = this.Root;

//            while (current != null && !this.AreEqual(element, current.Value))
//            {
//                if (this.IsLess(element, current.Value))
//                {
//                    current = current.LeftChild;
//                }
//                else if (this.IsGreater(element, current.Value))
//                {
//                    current = current.RightChild;
//                }
//            }

//            return new BinarySearchTree<T>(current);
//        }

//        private bool IsLess(T element, T value)
//        {
//            return element.CompareTo(value) < 0;
//        }

//        private bool IsGreater(T element, T value)
//        {
//            return element.CompareTo(value) > 0;
//        }

//        private bool AreEqual(T element, T value)
//        {
//            return element.CompareTo(value) == 0;
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
