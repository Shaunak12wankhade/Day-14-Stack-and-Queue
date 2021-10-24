using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to stack and queue");

            Console.WriteLine("Stack & Queue");
            StackQueue<int> stackListNode = new StackQueue<int>();
            stackListNode.Push(70);
            stackListNode.Push(30);
            stackListNode.Push(56);
            stackListNode.Show();
        }
    }
}
