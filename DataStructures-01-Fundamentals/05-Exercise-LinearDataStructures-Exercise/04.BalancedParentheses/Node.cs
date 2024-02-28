namespace Problem04.BalancedParentheses
{
    public class Node<T>{
        public T Item { get; set; }
        public Node<T> Next { get; set; }

        public Node(T item, Node<T> next = null)
        {
            this.Item = item;
            this.Next = next;
        }
    }
}