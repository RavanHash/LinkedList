using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedList
{
    internal partial class Program
    {
        static int Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            Node<int> a = new Node<int>(1);
            linkedList.AddNodeToEnd(a);
            
            Node<int> b = new Node<int>(2);
            linkedList.AddNodeToEnd(b);
            
            Node<int> c = new Node<int>(-111);
            linkedList.AddNodeToEnd(c); 
            
            Node<int> newnNode = new Node<int>(222222);
            linkedList.AddNodeAfter(newnNode, b);

            //linkedList.RemoveFirst();

            //linkedList.RemoveNode(a);

            linkedList.OutputList();

            //Console.WriteLine();
            //Node<int> target = linkedList.FindeNode(0);
            //Console.WriteLine(target.Data);

            List<int> list = new List<int>();
            

            Console.ReadKey();

            return 0;
        }
    }
}
