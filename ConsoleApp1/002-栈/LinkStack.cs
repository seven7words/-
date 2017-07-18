using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class LinkStack<T>:IStackDS<T>
    {
        private Node<T> top;//栈顶
        private int count = 0;//栈中元素个数
        
        public int Count
        {
            get { return count; }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            T data = top.Data;
            top = top.Next;

            return data;
        }

        public T Peek()
        {
            return top.Data;
        }
    }
}
