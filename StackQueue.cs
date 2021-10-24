using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackandqueue
{
   
        class StackQueue<Gtype>
        {
            private Node<Gtype> top;
            public StackQueue()
            {
                this.top = null;

            }
            public void Push(int d)
            {
                Node<Gtype> node = new Node<Gtype>(d);
                if (this.top == null)
                    node.Next = null;
                else
                    node.Next = this.top;
                this.top = node;
                Console.WriteLine($"data : {d}");
            }
            public void Show()
            {
                Node<Gtype> temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine($"{temp.Data} ");
                    temp = temp.Next;
                }
            }
        }
}
