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
            CustomList<int> newList = new CustomList<int>();
            newList.Add(10);
            newList.Add(15);
            newList.Add(20);
            newList.Add(25);
            newList.Add(30);
            Console.WriteLine(newList.Count);
            Console.WriteLine(newList.Capacity);
            Console.ReadLine();
        }
    }
}
