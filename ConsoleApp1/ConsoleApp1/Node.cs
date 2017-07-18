using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 单链表的节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Node<T>
    {
        private T data;//存储数据
        private Node<T> next;//指针用来指向下一个元素

        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.data = value;
            this.next = next;
        }

        public Node(Node<T> next)
        {
            this.next = next;
        }
        public T Data { get => data; set => data = value; }
        internal Node<T> Next { get => next; set => next = value; }
    }
}
