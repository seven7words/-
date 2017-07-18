using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_队列
{
    class LinkQueue<T>:IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int count;

        public LinkQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

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
            front = null;
            rear = null;
            count = 0;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (count == 0)
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                return default(T);
            }
            else if (count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;
            }
        }

        public T Peek()
        {
            if (front != null)
            {
                return front.Data;
            }
            else
            {
                return default(T);
            }
        }
    }
}
