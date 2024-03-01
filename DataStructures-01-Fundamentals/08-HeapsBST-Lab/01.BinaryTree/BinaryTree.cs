namespace _01.BinaryTree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BinaryTree<T> : IAbstractBinaryTree<T>
    {
        public BinaryTree(T value
            , IAbstractBinaryTree<T> leftChild
            , IAbstractBinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value { get; private set; }

        public IAbstractBinaryTree<T> LeftChild { get; private set; }

        public IAbstractBinaryTree<T> RightChild { get; private set; }

        public string AsIndentedPreOrder(int indent)
        {
            //throw new NotImplementedException();
            StringBuilder result = new StringBuilder();

            //result.AppendLine(this.Value.ToString());
            this.AsIndendedPreOrderDfs(this, indent, result);

            return result.ToString();
        }

        private void AsIndendedPreOrderDfs(IAbstractBinaryTree<T> current, int indent, StringBuilder result)
        {
            result.AppendLine($"{new string(' ', indent)}{current.Value}");
            if (current.LeftChild != null)
            {
                this.AsIndendedPreOrderDfs(current.LeftChild, indent + 2, result);
            }
            
            if (current.RightChild != null)
            {
                //result.AppendLine($"{new string(' ', indent)}" + this.RightChild.Value);
                this.AsIndendedPreOrderDfs(current.RightChild, indent + 2, result);
            }
        }

        public List<IAbstractBinaryTree<T>> InOrder()
        {
            //throw new NotImplementedException();
            List<IAbstractBinaryTree<T>> inOrderElements = new List<IAbstractBinaryTree<T>>();

            if (this.LeftChild != null)
            {
                inOrderElements.AddRange(this.LeftChild.InOrder());
            }

            inOrderElements.Add(this);

            if (this.RightChild != null)
            {
                inOrderElements.AddRange(this.RightChild.InOrder());
            }

            return inOrderElements;
        }

        public List<IAbstractBinaryTree<T>> PostOrder()
        {
            //throw new NotImplementedException();
            List<IAbstractBinaryTree<T>> postOrderElements = new List<IAbstractBinaryTree<T>>();

            if (this.LeftChild != null)
            {
                postOrderElements.AddRange(this.LeftChild.PostOrder());
            }

            if (this.RightChild != null)
            {
                postOrderElements.AddRange(this.RightChild.PostOrder());
            }

            postOrderElements.Add(this);

            return postOrderElements;

        }

        public List<IAbstractBinaryTree<T>> PreOrder()
        {
            //throw new NotImplementedException();
            List<IAbstractBinaryTree<T>> preOrderElements = new List<IAbstractBinaryTree<T>>();

            preOrderElements.Add(this);

            if (this.LeftChild != null)
            {
                preOrderElements.AddRange(this.LeftChild.PreOrder());
            }

            if (this.RightChild != null)
            {
                preOrderElements.AddRange(this.RightChild.PreOrder());
            }

            return preOrderElements;
        }

        public void ForEachInOrder(Action<T> action)
        {
            //throw new NotImplementedException();
            if (this.LeftChild != null)
            {
                this.LeftChild.ForEachInOrder(action);
            }

            action.Invoke(this.Value);

            if (this.RightChild != null)
            {
                this.RightChild.ForEachInOrder(action);
            }
        }
    }
}
