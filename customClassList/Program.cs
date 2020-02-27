using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customClassList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(1);
            myList2.Add(6);
            myList2.Add(8);
            CustomList<int> myList3 = new CustomList<int>();
            myList3 = myList3.Zip(myList1, myList2);
            Console.WriteLine(myList3.ToString());
            Console.WriteLine(myList3[2]);
            //CustomList<int> newList2 = new CustomList<int>();
            //newList2.Add(1);
            //newList2.Add(2);
            //newList2.Add(3);
            //CustomList<int> newlist3 = newList1 + newList2;
            //Console.WriteLine(newlist3);
            Console.ReadLine();
        }
    }
}
