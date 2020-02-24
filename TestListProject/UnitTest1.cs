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

        [TestMethod]
        public void AddObjectsToListTest_CorrectArraySize()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueToAdd = 10;
            int valueToAdd1 = 15;
            int valueToAdd2 = 20;
            int valueToAdd3 = 25;
            int valueToAdd4 = 30;
            int expected = 8;
            int actual;

            myList.AddToList(valueToAdd);
            myList.AddToList(valueToAdd1);
            myList.AddToList(valueToAdd2);
            myList.AddToList(valueToAdd3);
            myList.AddToList(valueToAdd4);
            actual = myList.Length;

            Assert.AreEqual(expected, actual);
        }

        public void AddObjectsToListTest_FirstItemHasCorrectName()
        {
            CustomList<string> myList = new CustomList<string>();
            string name = "Andrew";
            string expected = "Andrew";
            string actual;

            myList.AddToList(name);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }
    }
}
