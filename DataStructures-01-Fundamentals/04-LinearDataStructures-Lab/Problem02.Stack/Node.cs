namespace Problem02.Stack
{
    public class Node<T>
    {
        // TODO: Implement
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value, Node<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}