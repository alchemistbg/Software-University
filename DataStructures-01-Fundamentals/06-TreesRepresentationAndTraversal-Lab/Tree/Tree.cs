namespace Tree
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;

    public class Tree<T> : IAbstractTree<T>
    {
        private readonly List<Tree<T>> _children;

        public Tree(T value)
        {
            //throw new NotImplementedException();
            this.Value = value;
            this.Parent = null;
            this._children = new List<Tree<T>>();
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            //throw new NotImplementedException();
            //this.Value = value;
            //this.Parent = null;
            foreach (Tree<T> child in children)
            {
                child.Parent = this;
                this._children.Add(child);
            }
        }

        public T Value { get; private set; }
        public Tree<T> Parent { get; private set; }
        public IReadOnlyCollection<Tree<T>> Children => this._children.AsReadOnly();

        public bool IsRootDeleted { get; private set; }

        public ICollection<T> OrderBfs()
        {
            //throw new NotImplementedException();
            List<T> result = new List<T>();
            if (this.IsRootDeleted)
            {
                return result;
            }

            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                Tree<T> subTree = queue.Dequeue();
                result.Add(subTree.Value);

                foreach (Tree<T> child in subTree.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }

        public ICollection<T> OrderDfs()
        {
            //throw new NotImplementedException();
            //Recursive solution
            //List<T> result = new List<T>();
            //if (this.IsRootDeleted)
            //{
            //    return result;
            //}
            //this.DfsWithRecursion(this, result);
            //return result;


            //Stack solution
            //This is done in order to transform Stack to IColection
            if (this.IsRootDeleted)
            {
                return new List<T>();
            }
            List<T> result = new List<T>(this.DfsWithStack());
            return result;
            //return this.DfsWithStack();
        }

        //Recursive solution
        private void DfsWithRecursion(Tree<T> subTree, List<T> result)
        {
            foreach (Tree<T> child in subTree.Children)
            {
                this.DfsWithRecursion(child, result);
            }

            result.Add(subTree.Value);
        }

        private ICollection<T> DfsWithStack()
        {
            Stack<T> result = new Stack<T>();
            Stack<Tree<T>> toTraverse = new Stack<Tree<T>>();

            toTraverse.Push(this);

            while (toTraverse.Count > 0)
            {
                Tree<T> subTree = toTraverse.Pop();

                foreach (Tree<T> child in subTree.Children)
                {
                    toTraverse.Push(child);
                }

                result.Push(subTree.Value);
            }

            return new List<T>(result);
        }

        public void AddChild(T parentKey, Tree<T> child)
        {
            //throw new NotImplementedException();
            //Using BFS
            Tree<T> targetSubTree = this.FindBfs(parentKey);
            //Using DFS
            //Tree<T> targetSubTree = this.FindDfs(parentKey, this);
            this.CheckNode(targetSubTree);

            targetSubTree._children.Add(child);
        }

        public void RemoveNode(T nodeKey)
        {
            //throw new NotImplementedException();
            Tree<T> targetSubTree = this.FindBfs(nodeKey);
            this.CheckNode(targetSubTree);

            foreach (Tree<T> child in targetSubTree.Children)
            {
                child.Parent = null;
            }

            targetSubTree._children.Clear();

            Tree<T> targetSubTreeParent = targetSubTree.Parent;

            if (targetSubTreeParent == null)
            {
                this.IsRootDeleted = true;
            }
            else
            {
                targetSubTreeParent._children.Remove(targetSubTree);
            }

            //Optional
            //targetSubTree.Value = default(T);
        }
        
        public void Swap(T leftKey, T rightKey)
        {
            //throw new NotImplementedException();
            Tree<T> leftNode = this.FindBfs(leftKey);
            this.CheckNode(leftNode);
            Tree<T> rightNode = this.FindBfs(rightKey);
            this.CheckNode(rightNode);

            Tree<T> leftNodeParent = leftNode.Parent;
            Tree<T> rightNodeParent = rightNode.Parent;

            if (leftNodeParent == null)
            {
                this.SwapRoot(leftNode, rightNode);
                return;
            }
            
            if (rightNodeParent == null)
            {
                this.SwapRoot(rightNode, leftNode);
                return;
            }

            leftNode.Parent = rightNodeParent;
            rightNode.Parent = leftNodeParent;

            int indexOfLeftNode = leftNodeParent._children.IndexOf(leftNode);
            int indexOfRightNode = rightNodeParent._children.IndexOf(rightNode);

            leftNodeParent._children[indexOfLeftNode] = rightNode;
            rightNodeParent._children[indexOfRightNode] = leftNode;
            
        }

        private void SwapRoot(Tree<T> fNode, Tree<T> sNode)
        {
            fNode.Value = sNode.Value;
            fNode._children.Clear();
            foreach (Tree<T> child in sNode.Children)
            {
                fNode._children.Add(child);
            }
        }

        private Tree<T> FindBfs(T parentKey)
        {
            //Tree<T> result = null;

            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                Tree<T> subTree = queue.Dequeue();

                if (subTree.Value.Equals(parentKey))
                {
                    return subTree;
                }

                foreach (Tree<T> child in subTree.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return null;
        }

        private Tree<T> FindDfs(T value, Tree<T> subTree)
        {
            if (subTree.Value.Equals(value))
            {
                return subTree;
            }

            foreach (Tree<T> child in subTree.Children)
            {
                Tree<T> current = this.FindDfs(value, child);

                if (current != null && current.Value.Equals(value))
                {
                    return current;
                }
            }

            //This if check is moved on top
            //if (subTree.Value.Equals(value))
            //{
            //    return subTree;
            //}

            return null;
        }

        private void CheckNode(Tree<T> subTree)
        {
            if (subTree == null)
            {
                throw new ArgumentNullException("Searched element not found");
            }
        }
    }
}
