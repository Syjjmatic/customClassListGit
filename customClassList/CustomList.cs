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
            if (count < 4)
            {
                if (count == 0)
                {
                    count++;
                    items[0] = item;
                }
                else if (count == 1)
                {
                    count++;
                    items[1] = item;
                }
                else if (count == 2)
                {
                    count++;
                    items[2] = item;
                }
                else if (count == 3)
                {
                    count++;
                    items[3] = item;
                }
            }
            else if (count >= 4 && count < 8)
            {
                capacity *= 2;
                T[] copy = new T[4];
                copy = items;
                items = new T[capacity];
                for (int i = 0; i < copy.Length; i++)
                {
                    items[i] = copy[i];
                }

                if (count == 4)
                {
                    count++;
                    items[4] = item;
                }
                else if (count == 5)
                {
                    count++;
                    items[5] = item;
                }
                else if (count == 6)
                {
                    count++;
                    items[6] = item;
                }
                else if(count == 7)
                {
                    count++;
                    items[7] = item;
                }
            }

      


            // Each time an item is added, the list's count is increased by 1
            // The first item in the list is in index 1
            // The second item in the list is in index 2
            // If there are more than 4 items, but less than 9, the array size is 8
            // The item in the first index has the name of the first item added
        }

        public void Remove(T item)
        {
            count--;
            for (int i = 0; i < items.Length; i++)
            {
                //if (item == items[i]) // pick back up tomorrow 2/25
                //{

                //}

            }

            // Each time an item is removed, the list's count is reduced by 1
            // There should be nothing in index 1 if one item was in the list and it was removed; throw range exception
            // The item in index 1 should be the item that was previously in index 2 before the item in index 1 was removed
            // If you add two items and remove one, calling calling index 1 should throw an out of range exception
            // Removing two items should reduce the count by two
        }
    }
}
