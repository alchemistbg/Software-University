namespace Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TreeFactory
    {
        private Dictionary<int, Tree<int>> nodesByKeys;

        public TreeFactory()
        {
            this.nodesByKeys = new Dictionary<int, Tree<int>>();
        }

        public Tree<int> CreateTreeFromStrings(string[] input)
        {
            //throw new NotImplementedException();
            foreach (string line in input)
            {
                int[] keys = line.Split(' ').Select(int.Parse).ToArray();

                int parentKey = keys[0];
                int childKey = keys[1];

                this.AddEdge(parentKey, childKey);
            }

            return this.GetRoot();
        }

        public Tree<int> CreateNodeByKey(int key)
        {
            //throw new NotImplementedException();
            if (!this.nodesByKeys.ContainsKey(key))
            {
                this.nodesByKeys.Add(key, new Tree<int>(key)) ;
            }
            return this.nodesByKeys[key];
        }

        public void AddEdge(int parent, int child)
        {
            //throw new NotImplementedException();

            var parentNode = this.CreateNodeByKey(parent);
            var childNode = this.CreateNodeByKey(child);

            parentNode.AddChild(childNode);
            childNode.AddParent(parentNode);
        }

        private Tree<int> GetRoot()
        {
            //throw new NotImplementedException();
            foreach (var node in nodesByKeys)
            {
                if (node.Value.Parent == null)
                {
                    return node.Value;
                }
            }

            return null;
        }
    }
}
