using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customClassList
{
    public class CustomList<T>
    {
        T[] items;
        int count;
        int capacity;
        public int Count 
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int i]
        {
            get 
            {
                if (i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[i];
            }
            set { items[i] = value; }
        }

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if(count == capacity)
            {
                capacity *= 2;
                CopyItems();
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            // ToString

            for (int i = 0; i < count; i++) // for every item
            {
                if (item.Equals(items[i])) // check to see if item input and index are the same
                {
                    for (int j = i; j < count; j++) // if true, move all items down one and leave previous last index set to default
                    {
                        items[j] = items[j + 1];
                    }
                    items[count] = default;
                }
            }

            count--;
        }

        public void CopyItems()
        {
            T[] copy = new T[count];
            copy = items;
            items = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                items[i] = copy[i];
            }
        }
    }
}
