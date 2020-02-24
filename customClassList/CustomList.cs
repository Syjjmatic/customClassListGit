using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customClassList
{
    public class CustomList<T>
    {
        public void AddToList(T someData)
        {
            // Each time an item is added, the list's count is increased by 1
            // The first item in the list is in index 1
            // The second item in the list is in index 2
            // If there are more than 4 items, but less than 9, the array size is 8
            // The item in the first index has the name of the first item added
        }
    }
}
