using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB14.QueueExample
{
    public class QueueAsArray
    {
        private object[] items;

        public int Count { get; private set; }

        public QueueAsArray(int length = 0)
        {
            items = new object[length == 0 ? 10 : length];
        }

        public void Enqueue(object item)
        {
            grow();

            items[Count] = item;

            Count++;
        }

        public object Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in queue.");

            return items[0];
        }

        public object Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("No items in queue.");

            object item = items[0];

            Array.Copy(items, 1, items, 0, Count - 1);

            items[Count - 1] = default(object);

            Count--;

            return item;
        }

        public void Clear()
        {
            items = new object[10];
            Count = 0;
        }

        private void grow()
        {
            // Überprüfen, ob noch Platz
            if (items.Length >= Count + 1)
                return;

            // Array-Kapazität verdoppeln
            int newLength = items.Length * 2;

            Array.Resize(ref items, newLength);
        }
    }
}
