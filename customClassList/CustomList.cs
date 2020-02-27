using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace customClassList
{
    public class CustomList<T> : IEnumerable
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                IncreaseCapacity();
                CopyItems();
            }

            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(items[i]))
                {
                    for (int j = i; j < count; j++)
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

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> l3 = new CustomList<T>();
            foreach (T item in list1)
            {
                l3.Add(item);
            }
            foreach (T item in list2)
            {
                l3.Add(item);
            }

            return l3;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {

            foreach (T list1Item in list1)
            {
                foreach (T list2Item in list2)
                {
                    if (list1Item.Equals(list2Item))
                    {
                        list1.Remove(list1Item);
                    }
                }
            }

            return list1;
        }

        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> returnList = new CustomList<T>();

            if (count >= list.count)
            {                
                for (int i = 0; i < count; i++)
                {
                    ZipTwoItems(i, list.count, returnList, list);
                }
            }
            else if (list.count > count)
            {
                for (int i = 0; i < list.count; i++)
                {
                    ZipTwoItems(i, list.count, returnList, list);
                }
            }

            return returnList;
        }

        public void ZipTwoItems(int i, int listCount, CustomList<T> returnList, CustomList<T> list)
        {
            if (i < count)
            {
                returnList.Add(items[i]);
            }
            if (i < listCount)
            {
                returnList.Add(list[i]);
            }
        }
    }
}
