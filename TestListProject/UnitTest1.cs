using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customClassList;

namespace TestListProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddObjectsToListTest_CountIncreased()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueToAdd = 10;
            int expected = 1;
            int actual;

            myList.AddToList(valueToAdd);
            actual = myList.Count;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToListTest_TheFirstItemIndexIsZero()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueToAdd = 10;
            int expected = 10;
            int actual;

            myList.AddToList(valueToAdd);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToListTest_TheSecondItemIndexIsOne()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueToAdd = 10;
            int valueToAdd1 = 15;
            int expected = 15;
            int actual;

            myList.AddToList(valueToAdd);
            myList.AddToList(valueToAdd1);
            actual = myList[1];

            Assert.AreEqual(expected, actual);


        }
    }
}
