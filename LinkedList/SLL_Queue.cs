using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    class SLL_Queue<T> where T : IComparable
    {
        SLL_Node<T> head;
        SLL_Node<T> tail;
        int size;
        public SLL_Node<T> Head { get => head; }
        public SLL_Node<T> Tail { get => tail; }
        public int Size { get => size; }
        public SLL_Queue()
        {
            this.size = 0;
        }
        public void addNode(SLL_Node<T> node)
        {
            if (head == null) { head = node; tail = node; }
            else
            {
                tail.Next = node;
                tail = node;
            }
            this.size++;
        }
        public void addNode(T value)
        {
            SLL_Node<T> node = new SLL_Node<T>(value, null);
            if (head == null) { head = node; tail = node; }
            else
            {
                tail.Next = node;
                tail = node;
            }
            this.size++;
        }
        public void addAllNode(SLL_Queue<T> list)
        {
            if (head == null)
            {
                head = list.Head;
                tail = list.Tail;
            }
            else
            {
                tail.Next = list.Head;
                tail = list.Tail;
            }
            this.size += list.Size;
        }
        public bool isEmpty()
        {
            return head == null;
        }
        // u have to check if the list is empty or not before using poll method
        public T poll()
        {
            if (this.isEmpty()) {throw new Exception("list is empty"); }
            T tmp = head.Value;
            head = head.Next;
            this.size--;
            return tmp;

        }
        public void Display()
        {
            SLL_Node<T> ptr = head;
            while(ptr != null)
            {
                Console.Write("  {0}  ", ptr.Value);
                ptr = ptr.Next;
            }
            Console.Write("  Size = {0}  \n", Size);
        }
    }
}
