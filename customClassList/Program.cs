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
            CustomList<int> myList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> myList2 = new CustomList<int>() { 2, 4, 6, 8 };       
            CustomList<int> myList3 = myList1.Zip(myList2);
            Console.WriteLine(myList3.ToString());
            Console.ReadLine();
        }
    }
}
