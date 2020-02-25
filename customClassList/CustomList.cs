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
            get { return items[i]; }
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
            if (count >= 4 && count < 8)
            {
                capacity = 4 * 2;
                CopyItems();
            }
            else if (count >= 8 && count < 16)
            {
                capacity = 4 * (2 ^ 2);
                CopyItems();
            }
            else if (count >= 16 && count < 32)
            {
                capacity = 4 * (2 ^ 3);
                CopyItems();
            }
            else if (count >= 32 && count < 64)
            {
                capacity = 4 * (2 ^ 4);
                CopyItems();
            }

            items[count] = item;
            count++;
            
            // Each time an item is added, the list's count is increased by 1
            // The first item in the list is in index 1
            // The second item in the list is in index 2
            // If there are more than 4 items, but less than 9, the array size is 8
            // The item in the first index has the name of the first item added
        }

        public void Remove(T item)
        {
            count--;
            // ToString

            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {

                }

            }

            // Each time an item is removed, the list's count is reduced by 1
            // There should be nothing in index 1 if one item was in the list and it was removed; throw range exception
            // The item in index 1 should be the item that was previously in index 2 before the item in index 1 was removed
            // If you add two items and remove one, calling calling index 1 should throw an out of range exception
            // Removing two items should reduce the count by two
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
