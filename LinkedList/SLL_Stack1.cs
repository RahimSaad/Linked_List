using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedList
{
    class SLL_Stack1<T> where T :  IComparable
    {
        SLL_Node<T> head;
        int size;
        public SLL_Node<T> Head { get => head; }
        public int Size { get => size; }

        public delegate bool findDelegate(SLL_Node<T> node);

        public SLL_Stack1()
        {
            this.size = 0;
        }

        public SLL_Stack1<T> find(findDelegate isNodeOkay)
        {
            SLL_Stack1<T> result = new SLL_Stack1<T>();
            SLL_Node<T> tmp = Head;
            while (tmp != null)
            {
                if (isNodeOkay(tmp))
                {
                    result.addNode(tmp.Value);
                }
                tmp = tmp.Next;
            }
            return result;
        }

        public void sort()
        {
            
        }

        public void Reverse() 
        {
            SLL_Stack1<T> tmpSLL = new SLL_Stack1<T>();
            while (head != null)
            {
                tmpSLL.addNode(head.Value);
                head = head.Next;
                size--;
            }
            this.head = tmpSLL.Head;           
        }

        public void addNode(SLL_Node<T> node)
        {
            if (head == null) { head = node; }
            else
            {
                node.Next = head;
                head = node;
            }
            this.size++;
        }

        public void addNode(T value)
        {
            SLL_Node<T> node = new SLL_Node<T>(value, null);
            if (head == null) { head = node; }
            else
            {
                node.Next = head;
                head = node;
            }
            this.size++;
        }

        public void addAllNode(SLL_Stack1<T> list)
        {
            if (head == null) { head = list.Head; }
            else
            {
                SLL_Node<T> tail = list.getTail();
                tail.Next = head;
                head = list.Head;
            }
            this.size += list.Size;
        }

        public void addAllNode(List<T> arrList)
        {
            addAllNode(SLL_Stack1<T>.ListToLinkedList(arrList));
        }

        public SLL_Node<T> getTail()
        {
            SLL_Node<T> ptr = Head;
            while (ptr.Next != null)
            {
                ptr = ptr.Next;
            }
            return ptr;
        }
        
        public void swap(SLL_Node<T> x1, SLL_Node<T> x2)
        {
            T tmp = x1.Value;
            x1.Value = x2.Value;
            x2.Value = tmp;
        }

        public bool search(T value, out int idx)
        {
            idx = 0;
            SLL_Node<T> tmp = Head;
            while (tmp != null)
            {
                if (tmp.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                tmp = tmp.Next;
                idx++;
            }
            idx = -1;
            return false;
        }
        
        public bool InsertAt(int idx, SLL_Node<T> newNode)
        {
            if (idx < 0 || idx > size) { return false; }
            if (idx == 0 && head == null) { addNode(newNode); return true; } 
            
            SLL_Node<T> tmp = head;
            int counter = 0;
            if (idx == 0)
            {
                newNode.Next = head;
                head = newNode;
            }

            else
            {
                while (counter < (idx - 1))
                {
                    tmp = tmp.Next;
                    counter++;
                }
                newNode.Next = tmp.Next;
                tmp.Next = newNode;
            }
            this.size++;
            return true;
        }

        public bool insertAllAt(int idx, SLL_Stack1<T> list)
        {
            if (list == this) { return false; }
            if (idx < 0) { return false; }
            if (idx > size) { return false; }
            if (idx==0 && head == null) { addAllNode(list); return true; } 

            SLL_Node<T> tmp = head;
            int counter = 0;
            if (idx == 0)
            {
                list.getTail().Next = head;
                head = list.Head;
            }
            while (counter < (idx - 1))
            {
                tmp = tmp.Next;
                counter++;
            }

            list.getTail().Next = tmp.Next;
            tmp.Next = list.Head;
            this.size += list.Size;
            return true;
        }

        public bool InsertAt(int idx, T value)
        {
            return InsertAt(idx, new SLL_Node<T>(value, null));
        }
        public bool Remove(SLL_Node<T> node)
        {
            SLL_Node<T> tmp = head;
            while (tmp != null)
            {
                if (tmp.Next == node)
                {
                    tmp.Next = tmp.Next.Next;
                    this.size--;
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }

        public bool RemoveFirst()
        {
            if (head == null) { return false; }
            head = head.Next;
            this.size--;
            return true;
        }

        public bool RemoveFromTo(int from, int to) // excluding (to)
        {
            // validate that  [from < to <=  size]
            if (from < 0) { return false; } // gurantee that from is positive
            if (to <= from) { return false; } // gurantee that to > from && to is positive since it is greater than from a positive
            if (to > size) { return false; } // gurantee that to does not exceed the boundry
            
            SLL_Node<T> tmp1 = head;
            SLL_Node<T> tmp2;
            int counter = 0;
            if (from == 0)
            {
                tmp2 = head;
                while (counter < to) { tmp2 = tmp2.Next; counter++; }
                head = tmp2;
            }
            else
            {
                while (counter < (from - 1)) { tmp1 = tmp1.Next; counter++; }
                tmp2 = tmp1;
                while (counter < to) { tmp2 = tmp2.Next; counter++; }
                tmp1.Next = tmp2;
            }
            
            size -= (to - from);

            return true;
        }

        public bool RemoveLast()
        {
            return RemoveFromTo(size - 1, size);
        }

        public static SLL_Stack1<T> ListToLinkedList(List<T> arrList)
        {
            SLL_Stack1<T> tmp = new SLL_Stack1<T>();
            foreach (T item in arrList)
            {
                tmp.addNode(item);
            }
            return tmp;
        }
        
        public void Display()
        {
            SLL_Node<T> tmp = head;
            while (tmp != null)
            {
                Console.Write("  {0}  ", tmp.Value);
                tmp = tmp.Next;
            }
            Console.Write("  Size = {0}  \n", Size);
        }

    }
}
