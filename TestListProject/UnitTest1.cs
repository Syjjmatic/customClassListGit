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
            actual = myList.Count;

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
            actual = myList.Capacity;

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
            myList.Remove(value);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveObjectsFromList_Test_NoItemsInListThrowException()
        {
            CustomList<int> myList = new CustomList<int>();
            int value = 10;
            int actual;
            myList.Add(value);
            myList.Remove(value);
            actual = myList[0];
        }

        [TestMethod]
        public void RemoveObjectsFromList_Test_NameOfItemInIndexOne()
        {
            CustomList<string> myList = new CustomList<string>();
            string string1 = "Andrew";
            string string2 = "Curzon";
            string expected = string2;
            string actual;

            myList.Add(string1);
            myList.Add(string2);
            myList.Remove(string1);
            actual = myList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveObjectsFromList_Test_ItemNoLongerInLocationThrowException()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 15;
            int actual;
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);
            actual = myList[1];
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
            myList.Remove(string1);
            myList.Remove(string2);
            actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoLists_CheckNewListCount()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = myList1.Count + myList2.Count;
            int actual;
            
            CustomList<int> myList3 = myList1 + myList2;
            actual = myList3.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoLists_ItemsInCorrectOrder()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();

            CustomList<int> myList3 = myList1 + myList2;
            bool isTrue = default;

            for (int i = 0; i < myList3.Count; i++)
            {
                if (i < i + 1)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }

            Assert.IsTrue(isTrue);
        }
    }
}
