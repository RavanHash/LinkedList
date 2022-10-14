namespace LinkedList
{
    internal partial class Program
    {
        public class Node <T>
        {
            public T Data;
            public Node<T> Next;

            public Node(T data)
            {
                this.Data = data;
                Next = null; 
            }
        }
    }
}
