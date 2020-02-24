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

        public void Add(T item)
        {
            if (count >= 0 && count < 4)
            {
                capacity = 4;

                if (items[1] == null)
                {
                    count++;
                    items[1] = item;
                }
                else if (items[1] != null && items[2] == null)
                {
                    count++;
                    items[2] = item;
                }
                else if (items[2] != null && items[3] == null)
                {
                    count++;
                    items[3] = item;
                }
                else if (items[3] != null && items[4] == null)
                {
                    count++;
                    items[4] = item;
                }
            }
            else if (count >= 4 && count < 8)
            {
                capacity *= 2;
                if (items[4] != null && items[5] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[5] != null && items[6] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[6] != null && items[7] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[7] != null && items[8] == null)
                {
                    count++;
                    items[5] = item;
                }
            }
            else if (count >= 8 && count < 12)
            {
                capacity *= 2;
                if (items[8] != null && items[9] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[9] != null && items[10] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[10] != null && items[11] == null)
                {
                    count++;
                    items[5] = item;
                }
                else if (items[11] != null && items[12] == null)
                {
                    count++;
                    items[5] = item;
                }

            }

            
            // Each time an item is added, the list's count is increased by 1
            // The first item in the list is in index 1
            // The second item in the list is in index 2
            // If there are more than 4 items, but less than 9, the array size is 8
            // The item in the first index has the name of the first item added
        }

        public void RemoveFromList(T item)
        {
            count--;

            // Each time an item is removed, the list's count is reduced by 1
            // There should be nothing in index 1 if one item was in the list and it was removed; throw range exception
            // The item in index 1 should be the item that was previously in index 2 before the item in index 1 was removed
            // If you add two items and remove one, calling calling index 1 should throw an out of range exception
            // Removing two items should reduce the count by two
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
