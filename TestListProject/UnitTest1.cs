using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customClassList;

namespace TestListProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddObjectsToList_Test_CountIncreased()
        {
            CustomList<int> myList = new CustomList<int>();
            int valueToAdd = 10;
            int expected = 1;
            int actual;

            myList.Add(valueToAdd);
            actual = myList.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToList_Test_TheFirstItemIndexIsZero()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            int expected = 10;
            int actual;

            myList.Add(value);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToList_Test_TheSecondItemIndexIsOne()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 15;
            int expected = value2;
            int actual;

            myList.Add(value1);
            myList.Add(value2);
            actual = myList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToList_Test_CorrectArrayCapacity()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            int value1 = 15;
            int value2 = 20;
            int value3 = 25;
            int value4 = 30;
            int expected = 8;
            int actual;

            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList.Capacity();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddObjectsToList_Test_FirstItemHasCorrectName()
        {
            CustomList<string> myList = new CustomList<string>();
            string name = "Andrew";
            string expected = name;
            string actual;

            myList.Add(name);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveObjectsFromList_Test_CountReduced()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            int expected = 0;
            int actual;

            myList.Add(value);
            myList.Add(value);
            actual = myList.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveObjectsFromList_Test_ItemsInIndexZero()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            IndexOutOfRangeException expected = new IndexOutOfRangeException();
            IndexOutOfRangeException actual;

            myList.Add(value);
            myList.RemoveFromList(value);
            actual = myList[0];
            //Argument out of range exception

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveObjectsFromList_Test_NameOfItemInIndex1()
        {
            CustomList<string> myList = new CustomList<string>();
            string string1 = "Andrew";
            string string2 = "Curzon";
            string expected = string2;
            string actual;

            myList.Add(string1);
            myList.Add(string2);
            myList.RemoveFromList(string1);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        ]public void RemoveObjectsFromList_Test_ItemNoLongerInIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 15;
            IndexOutOfRangeException expected = new IndexOutOfRangeException(); // need help
            IndexOutOfRangeException actual;

            myList.Add(value1);
            myList.Add(value2);
            myList.RemoveFromList(value1);
            actual = myList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveObjectsFromList_Test_ReduceCountByTwo()
        {
            CustomList<string> myList = new CustomList<string>();
            string string1 = "string1";
            string string2 = "string2";
            int expected = 0;
            int actual;

            myList.Add(string1);
            myList.Add(string2);
            myList.RemoveFromList(string1);
            myList.RemoveFromList(string2);
            actual = myList.Count();

            Assert.AreEqual(expected, actual);
        }
    }
}
