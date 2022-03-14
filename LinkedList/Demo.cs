using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    /*
     * linked list can be used like stack[last in first out] or like a queue[first in first out]
     * Dynamic memory allocation
     */
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------TestSLL_stack()------------");
            TestSLL_stack();
            Console.WriteLine("------------TestSLL_queue()------------");
            TestSLL_queue();
            Console.WriteLine("------------TestSLL_queue()------------");
            TestSLL_queue();
        }

        private static void TestDLL_queue()
        {
            
        }

        private static void TestDLL_stack()
        {
            DLL_Stack<int> stk = new DLL_Stack<int>();
            stk.addNode(1); stk.addNode(2); stk.addNode(3);
            stk.Display();
            while (!stk.isEmpty())
            {
                Console.Write(stk.poll()+"  ");
            }
            Console.WriteLine("size =  {0}",stk.Size);
        }

        private static void TestSLL_queue()
        {
            SLL_Queue<int> q = new SLL_Queue<int>();
            q.addNode(1); q.addNode(2); q.addNode(3); q.addNode(4); q.addNode(5);
            q.Display();
            while (!q.isEmpty())
            {
                Console.Write("  "+q.poll() + "  ");
            }
            Console.Write("  size = "+q.Size+"\n");
        }

        public static void TestSLL_stack()
        {
            SLL_Stack1<int> sll = new SLL_Stack1<int>();

            int i = 0;
            sll.addNode(i++);
            sll.addNode(i++);
            sll.addNode(i++);
            sll.addNode(i++);
            sll.addNode(i++);
            sll.addNode(i++);

            sll.Display();
            sll.RemoveFromTo(3, 5);
            sll.Display();
            sll.InsertAt(2, 77);
            sll.Display();
            sll.RemoveFirst();
            sll.Display();
            sll.addNode(96);
            sll.Display();
            sll.RemoveLast();
            sll.Display();

            SLL_Stack1<int> sll2 = new SLL_Stack1<int>();
            sll2.addNode(50); sll2.addNode(51); sll2.addNode(52);

            sll.insertAllAt(3, sll2);
            sll.Display();
            sll.InsertAt(1, 666);
            sll.Display();

            Console.WriteLine(sll.Head.Value);
            Console.WriteLine(sll.getTail().Value);

            sll.find(ptr => ptr.Value % 3 == 0).Display();
            
            Console.WriteLine("-------------------------------------------");
            SLL_Stack1<int> xStk = new SLL_Stack1<int>();
            xStk.addNode(1); xStk.addNode(2); xStk.addNode(3); xStk.addNode(4); xStk.addNode(5); xStk.addNode(6);
            Console.WriteLine("original List :");
            xStk.Display();
            Console.WriteLine("List after Reversing :");
            xStk.Reverse();
            xStk.Display();
            
        }
       
    }
}
