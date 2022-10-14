using System;

namespace LinkedList
{
    internal partial class Program
    {
        public class LinkedList<T>
        {
            public Node<T> Head;
            public Node<T> Last;
            public int Count;

            public LinkedList()
            {
                Head = null;
                Last = null;
                Count = 0;
            }


            public void AddNodeToBeginning(Node<T> newNode)
            {
                if(this.Head == null)
                {
                    this.Head = newNode;
                    this.Last = newNode;
                }
                else
                {
                    newNode.Next = this.Head;
                    this.Head = newNode;
                }
                Count++;
            }
            
            public void AddNodeToEnd(Node<T> newNode)
            {
                if(this.Head == null)
                {
                    this.Head= newNode;
                    this.Last = newNode;
                }
                else
                {
                    this.Last.Next = newNode;
                    this.Last = newNode;
                }
                Count++;
            }

            public void AddNodeAfter(Node<T> newNode, Node<T> existingNode)
            {
                if (this.Last == existingNode)
                {
                    Last = newNode;
                }
                newNode.Next = existingNode.Next;
                existingNode.Next = newNode;

                Count++;
            }

            public void RemoveFirst()
            {
                if(Head == null) return;

                Head = this.Head.Next;
                Count--;
            }

            public void RemoveNode(Node<T> nodeToBeRemoved)
            {
                if(Head == null) return ;

                if(Head == nodeToBeRemoved)
                {
                    RemoveFirst();
                    return;
                }

                Node<T> previousNode = this.Head;
                Node<T> currentNode = previousNode.Next;

                while(currentNode != null && currentNode != nodeToBeRemoved)
                {
                    previousNode = currentNode;
                    currentNode = previousNode.Next;
                }

                if(currentNode != null)
                {
                    previousNode.Next = currentNode.Next;
                    Count--;
                }
            }

            public Node<T> FindeNode(T target)
            {
                Node<T> currentNode = this.Head;

                while(currentNode != null && !currentNode.Data.Equals(target))
                {
                    currentNode = currentNode.Next;
                }

                return currentNode;
            }    

            public void OutputList()
            {
                Node<T> runner = Head;

                while (runner != null)
                {
                    Console.WriteLine(runner.Data);
                    runner = runner.Next;
                }
            }
        }
    }
}
