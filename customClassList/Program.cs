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
            newList.Remove(10);
            int atIndex = newList[0];
            Console.WriteLine(atIndex);
        }
    }
}
