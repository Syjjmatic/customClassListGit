﻿using System;
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

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> l3 = new CustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                l3.Add(list1.items[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                l3.Add(list2.items[i]);
            }

            return l3;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            
            for (int i = 0; i < list1.count; i++)
            {
                for (int j = 0; j < list2.count; j++)
                {
                    if (list1.items[i].Equals(list2.items[j]))
                    {
                        list1.Remove(list1.items[i]);
                    }
                }
            }

            return list1;
        }

        public CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();


            if (list1.count >= list2.count)
            {
                for (int i = 0; i < list1.count; i++)
                {
                    try
                    {
                        list3.Add(list1[i]);
                        if (i < list2.count)
                        {
                            list3.Add(list2[i]);
                        }
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            else if (list2.count > list1.count)
            {
                for (int i = 0; i < list2.count; i++)
                {
                    try
                    {
                        if(i < list1.count)
                        {
                            list3.Add(list1[i]);
                        }                        
                        list3.Add(list2[i]);
                    }
                    catch
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            return list3;
        }

    }
}
