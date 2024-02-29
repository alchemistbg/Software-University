namespace Tree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tree<T> : IAbstractTree<T>
    {
        private readonly List<Tree<T>> _children;

        public Tree(T key, params Tree<T>[] children)
        {
            //throw new NotImplementedException();
            this._children = new List<Tree<T>>();
            this.Key = key;
            foreach (var child in children)
            {
                this.AddChild(child);
                child.Parent = this;
            }
        }

        public T Key { get; private set; }

        public Tree<T> Parent { get; private set; }


        public IReadOnlyCollection<Tree<T>> Children
            => this._children.AsReadOnly();

        public void AddChild(Tree<T> child)
        {
            //throw new NotImplementedException();
            this._children.Add(child);
        }

        public void AddParent(Tree<T> parent)
        {
            //throw new NotImplementedException();
            this.Parent = parent;
        }

        //public string GetAsString()
        //{
        //    //throw new NotImplementedException();
        //    List<string> result = new List<string>();
        //    this.DfsToString(this, result);
        //    return string.Join("\r\n", result);
        //}

        //private void DfsToString(Tree<T> subtree, List<string> result, int level = 0)
        //{
        //    //A little optimiziation is done efter watching the lecture
        //    //if (subtree.Parent == null)
        //    //{
        //    //    result.Add(new string(' ', level) + subtree.Key.ToString());
        //    //}
        //    result.Add(new string(' ', level) + subtree.Key.ToString());

        //    //level += 2;
        //    foreach (var child in subtree.Children)
        //    {
        //        //result.Add(new string(' ', level) + child.Key.ToString());
        //        DfsToString(child, result, level + 2);
        //    }
        //}

        //Kiro solution
        public string GetAsString()
        {
            StringBuilder result = new StringBuilder();
            this.DfsToString(this, result);
            return result.ToString().Trim();
        }

        private void DfsToString(Tree<T> subtree, StringBuilder result, int level = 0)
        {
            //result.Append(new string(' ', level)).Append(subtree.Key).Append(Environment.NewLine);
            result.Append(new string(' ', level)).AppendLine(subtree.Key.ToString());

            foreach (var child in subtree.Children)
            {
                DfsToString(child, result, level + 2);
            }
        }
        //END of Kiro solution

        Tree<T> deepest = default;
        int depth = -1;
        public Tree<T> GetDeepestLeftomostNode()
        {
            int level = 0;
            this.runDfs(this, level);
            return deepest;
        }

        private void runDfs(Tree<T> subtree, int level)
        {
            //throw new NotImplementedException();
            if (subtree == null)
            {
                return;
            }

            if (level > depth)
            {
                depth = level;
                deepest = subtree;
            }

            foreach (Tree<T> child in subtree.Children)
            {
                runDfs(child, level+1);
            }
        }

        public List<T> GetLeafKeys()
        {
            //throw new NotImplementedException();
            //List<T> result = new List<T>();
            //this.findLeafNodes(this, result);
            //result.Sort();
            //return result;

            //Kiro solution
            List<T> leafNodes = new List<T>();
            Queue<Tree<T>> nodes = new Queue<Tree<T>>();

            nodes.Enqueue(this);

            while (nodes.Count > 0)
            {
                Tree<T> currentNode = nodes.Dequeue();

                if (this.IsLeaf(currentNode))
                {
                    leafNodes.Add(currentNode.Key);
                }

                foreach (Tree<T> child in currentNode.Children)
                {
                    nodes.Enqueue(child);
                }
            }

            return leafNodes;
        }

        private void findLeafNodes(Tree<T> subtree, List<T> result)
        {
            foreach (Tree<T> child in subtree.Children)
            {
                //if (child.Children.Count == 0)
                if (this.IsLeaf(child))
                {
                    result.Add(child.Key);
                }
                this.findLeafNodes(child, result);
            }
        }

        public List<T> GetMiddleKeys()
        {
            //throw new NotImplementedException();
            //List<T> result = new List<T>();
            //this.findMiddleNodes(this, result);
            //result.Sort();
            //return result;

            List<T> middleNodes = new List<T>();
            Queue<Tree<T>> nodes = new Queue<Tree<T>>();

            nodes.Enqueue(this);

            while (nodes.Count > 0)
            {
                Tree<T> currentNode = nodes.Dequeue();

                if (!this.IsRoot(currentNode) && !this.IsLeaf(currentNode))
                {
                    middleNodes.Add(currentNode.Key);
                }

                foreach (Tree<T> child in currentNode.Children)
                {
                    nodes.Enqueue(child);
                }
            }

            return middleNodes;
        }

        private void findMiddleNodes(Tree<T> subtree, List<T> result)
        {
            //throw new NotImplementedException();
            foreach (Tree<T> child in subtree.Children)
            {
                //if (child.Parent != null && child.Children.Count > 0)
                if (!this.IsRoot(child) && !this.IsLeaf(child))
                {
                    result.Add(child.Key);
                }
                this.findMiddleNodes(child, result);
            }
        }

        public List<T> GetLongestPath()
        {
            Tree<T> deepest = this.GetDeepestLeftomostNode();

            List<T> longestPath = new List<T>();
            Stack<T> longestPathStack = new Stack<T>();

            Tree<T> currentNode = deepest;
            //longestPathStack.Push(deepest.Key);
            //while (currentNode.Parent != null)
            while (currentNode != null)
            {
                //longestPath.Add(currentNode.Key);
                longestPathStack.Push(currentNode.Key);
                currentNode = currentNode.Parent;
            }

            //longestPath.Add(currentNode.Key);
            //longestPathStack.Push(currentNode.Key);

            //while (longestPathStack.Count > 0)
            //{
            //    longestPath.Add(longestPathStack.Pop());
            //}

            //longestPath.Reverse();
            //return longestPath;

            return new List<T>(longestPathStack);
        }

        public List<List<T>> PathsWithGivenSum(int sum)
        {
            //throw new NotImplementedException();
            List<List<T>> result = new List<List<T>>();
            List<T> currentPath = new List<T>();
            currentPath.Add(this.Key);
            int currentSum = Convert.ToInt32(this.Key);

            this.GetPathsWithGivenSumDfs(this, result, currentPath, sum, ref currentSum);
            return result;
        }

        private void GetPathsWithGivenSumDfs(Tree<T> subtree, List<List<T>> result, List<T> currentPath, int wantedSum, ref int currentSum)
        {
            foreach (Tree<T> child in subtree.Children)
            {
                currentPath.Add(child.Key);
                currentSum += Convert.ToInt32(child.Key);
                this.GetPathsWithGivenSumDfs(child, result, currentPath, wantedSum, ref currentSum);
            }

            if (currentSum == wantedSum)
            {
                result.Add(new List<T>(currentPath));
            }

            currentPath.RemoveAt(currentPath.Count - 1);
            currentSum -= Convert.ToInt32(subtree.Key);
        }

        public List<Tree<T>> SubTreesWithGivenSum(int sum)
        {
            List<Tree<T>> result = new List<Tree<T>>();
            var nodes = this.GetAllNodes(this);

            foreach (var node in nodes)
            {
                if (this.CalcNodeSum(node) == sum)
                {
                    result.Add(node);
                }
            }

            return result;
        }

        private int CalcNodeSum(Tree<T> node)
        {
            int sum = Convert.ToInt32(node.Key);
            int childSum = 0;

            foreach (var child in node.Children)
            {
                childSum += this.CalcNodeSum(child);
            }


            return sum + childSum;
        }

        private List<Tree<T>> GetAllNodes(Tree<T> subtree)
        {
            List<Tree<T>> result = new List<Tree<T>>();
            result.Add(subtree);

            Queue<Tree<T>> nodes = new Queue<Tree<T>>();
            nodes.Enqueue(subtree);

            while (nodes.Count > 0)
            {
                Tree<T> currentNode = nodes.Dequeue();

                foreach (var child in currentNode.Children)
                {
                    result.Add(child);
                    nodes.Enqueue(child);
                }
            }

            return result;
        }
        
        private bool IsRoot(Tree<T> node)
        {
            return node.Parent == null;
        }

        private bool IsLeaf(Tree<T> node)
        {
            return node.Children.Count == 0;
        }
    }
}
