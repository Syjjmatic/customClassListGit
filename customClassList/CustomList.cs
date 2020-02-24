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

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T data)
        {
            // Each time an item is added, the list's count is increased by 1
            // The first item in the list is in index 1
            // The second item in the list is in index 2
            // If there are more than 4 items, but less than 9, the array size is 8
            // The item in the first index has the name of the first item added
        }

        public void RemoveFromList(T data)
        {
            // Each time an item is added, the list's count is reduced by 1
            // There should be nothing in index 1 if one item was in the list and it was removed
            // The item in index 1 should be the item that was previously in index 2 before the item in index 1 was removed
        }

        public int Capacity()
        {
            return capacity;
        }

        public int Count()
        {
            return count;
        }
    }
}
