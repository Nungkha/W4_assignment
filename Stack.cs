using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_assignment
{
    public class Stack<T>
    {
        public List<T> items = new List<T>();

        public void DisplayItems()
        {
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                // initializing last item in item variable
                T item = items[items.Count - 1];

                // removing last item
                items.RemoveAt(items.Count - 1);
                return item;
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return default;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
            }
            return items[items.Count - 1];

        }

        private bool IsEmpty()
        {
            return items.Count == 0;
        }


    }
}
