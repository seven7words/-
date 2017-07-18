using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的Stack
            Stack<char> stack = new Stack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine(stack.Count);
            char temp = stack.Pop();
            Console.WriteLine(temp);
            Console.WriteLine(stack.Count);
            Console.ReadKey();
        }
    }
}
