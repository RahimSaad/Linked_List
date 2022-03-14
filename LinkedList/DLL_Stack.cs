using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinkedList
{
    class DLL_Stack<T> where T : IComparable
    {
        DLL_Node<T> head;
        int size;
        public DLL_Node<T> Head { get => head; }
        public int Size { get => size; }

        public DLL_Stack()
        {
            this.size = 0;
        }

        public void addNode(DLL_Node<T> node)
        {
            if (head == null) { head = node; }
            else
            {
                node.Next = head;
                head.Previous = node;
                head = node;
            }
            this.size++;
        }

        public void addNode(T value)
        {
            DLL_Node<T> node = new DLL_Node<T>(value, null, null);
            if (head == null) { head = node; }
            else
            {
                node.Next = head;
                head.Previous = node;
                head = node;
            }
            this.size++;
        }

        public void addAllNode(DLL_Stack<T> list)
        {
            if (head == null)
            {
                this.head = list.Head;
            }
            else
            {
                DLL_Node<T> t = list.getTail();
                t.Next = head;
                head.Previous = t;
                head = list.head;

            }
            this.size += list.Size;
        }

        private DLL_Node<T> getTail()
        {
            DLL_Node<T> ptr = head;
            while (ptr.Next != null)
            {
                ptr = ptr.Next;
            }
            return ptr;
        }

        public bool isEmpty()
        {
            return head == null;
        }

        // u have to check if the list is empty or not before using poll method
        public T poll()
        {
            if (head == null) { throw new Exception("list is empty"); }
            T tmp = head.Value;
            head = head.Next;
            if (Size > 1)  { head.Previous = null; }
            this.size--;
            return tmp;
        }

        public void Display()
        {
            DLL_Node<T> ptr = head;
            while (ptr != null)
            {
                Console.Write("  {0}  ", ptr.Value);
                ptr = ptr.Next;
            }
            Console.Write("  Size = {0}  \n", Size);
        }

    }
}
