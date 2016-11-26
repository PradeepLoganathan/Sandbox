using System;

namespace Datastructures.Lists
{
    public class SNode<T> where T : IComparable
    {
        private T _value;
        private SNode<T> _next;
        public SNode()
        {
            this.Value = default(T);
            Next = null;
        }
        public SNode(T value)
        {
            this.Value = value;
            Next = null;
        }

        public SNode<T> Next { get { return this._next; } set { _next = value; } }
        public T Value { get { return _value; } set { _value = value; } }
    }

    public class SLinkedList<T> where T : IComparable
    {
        private SNode<T> _head;
        private SNode<T> _tail;

        public SLinkedList()
        {
            _head = _tail = null;
        }

        public SNode<T> AddNode(T Value)
        {
            SNode<T> node = new SNode<T>(Value);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }

            return node;
        }

        public bool RemoveNode(T Value)
        {
            SNode<T> previous, current;

            for (current = _head, previous = _head; current.Next != null;)
            {
                if (current.Value.CompareTo(Value) == 0)
                {
                    previous.Next = current.Next;
                    return true;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
            return false;
        }

        public SNode<T> FindNode(T Value)
        {
            SNode<T> node = null;

            if (_head == null && _tail == null)
                return null;

            node = _head;
            while (node != _tail)
            {
                if (node.Value.CompareTo(Value) == 0)
                    return node;
            }

            return null;
        }

        public SNode<T> FindMid()
        {
            SNode<T> slownode, fastnode;
            for(slownode = fastnode = _head; fastnode.Next != null;slownode = slownode.Next,  fastnode = fastnode.Next.Next)
            {
                Console.WriteLine("slownode at {0}", slownode.Value.ToString());
                Console.WriteLine("fastnode at {0}", fastnode.Value.ToString());
            }
            return slownode;
        }

        public override string ToString()
        {
            SNode<T> node;
            string printer;

            printer = "| ";
            for (node = _head; node != null; node = node.Next)
                printer += node.Value + " |-->| ";
            printer += " null |";

            return printer;
        }

    }

}
