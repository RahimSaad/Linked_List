using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinkedList
{
    class SLL_Node<T>
    {
        T xValue;
        SLL_Node<T> next;
        public T Value { get => xValue; set => xValue = value; }
        public SLL_Node<T> Next { get => next; set => next = value; }

        public SLL_Node(T value, SLL_Node<T> next)
        {
            this.xValue = value;
            this.next = next;
        }

        
    }
}
