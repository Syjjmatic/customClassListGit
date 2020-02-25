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
            CustomList<int> newList1 = new CustomList<int>();
            newList1.Add(10);
            newList1.Add(15);
            newList1.Add(20);
            newList1.Add(25);
            newList1.Add(30);
            Console.WriteLine(newList1.Count);
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
