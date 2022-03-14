using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinkedList
{
    class DLL_Node<T>
    {
        T xValue;
        DLL_Node<T> next;
        DLL_Node<T> previous;
        public T Value { get => xValue; set => xValue = value; }
        public DLL_Node<T> Next { get => next; set => next = value; }
        public DLL_Node<T> Previous { get => previous; set => previous = value; }
        
        public DLL_Node(T value, DLL_Node<T> next, DLL_Node<T> previous)
        {
            this.xValue = value;
            this.next = next;
            this.previous = previous;
        }
    }
}
