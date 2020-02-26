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
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if(count == capacity)
            {
                IncreaseCapacity();
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

        void CopyItems()
        {
            T[] copy = new T[count];
            copy = items;
            items = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                items[i] = copy[i];
            }
        }

        void IncreaseCapacity()
        {
            capacity *= 2;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < count; i++)
            {
                if (str == "")
                {
                    str = "" + items[i];
                }
                else
                {
                    str = str + ", " + items[i];
                }
            }

            return str;
        }

        public static CustomList<T> operator +(CustomList<T> l1, CustomList<T> l2)
        {
            CustomList<T> l3 = new CustomList<T>();

            for (int i = 0; i < l1.count; i++)
            {
                l3.Add(l1.items[i]);
            }
            for (int i = 0; i < l2.count; i++)
            {
                l3.Add(l2.items[i]);
            }

            return l3;
        }
    }
}
