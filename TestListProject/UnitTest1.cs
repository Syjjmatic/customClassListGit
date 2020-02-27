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
        public void OverrideToString_ChangeIntToString()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            string expected = "10, 20";
            string actual;
            myList.Add(value1);
            myList.Add(value2);
            actual = myList.ToString();
            Assert.AreEqual(expected, actual);         
        }

        [TestMethod]
        public void OverrideToString_ChangeDoubleToString()
        {
            CustomList<double> myList = new CustomList<double>();
            double value1 = 2.75;
            double value2 = 17.46;
            string expected = "2.75, 17.46";
            string actual;
            myList.Add(value1);
            myList.Add(value2);
            actual = myList.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverrideToString_CheckIfStillInt()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 10;
            int value2 = 20;
            bool isInt = default;
            myList.Add(value1);
            myList.Add(value2);

            if (myList.ToString() == "10, 20")
            {
                isInt = false;
            }
            else
            {
                isInt = true;
            }
            Assert.IsFalse(isInt);

        }

        [TestMethod]
        public void AddTwoLists_CheckNewListCount()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 3;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            CustomList<int> myList3 = myList1 + myList2;
            actual = myList3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTwoLists_CheckFirstIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 1;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            CustomList<int> myList3 = myList1 + myList2;
            actual = myList3[0];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddTwoLists_CheckLastIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 3;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            CustomList<int> myList3 = myList1 + myList2;
            actual = myList3[2];
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddTwoLists_CountTheSameAsFirstListIfSecondListEmpty()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 2;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            CustomList<int> myList3 = myList1 + myList2;
            actual = myList3.Count;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddTwoLists_ReportAllItemsFromBothLists()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected1 = 1;
            int expected2 = 2;
            int expected3 = 3;
            int actual1;
            int actual2;
            int actual3;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            CustomList<int> myList3 = myList1 + myList2;
            actual1 = myList3[0];
            actual2 = myList3[1];
            actual3 = myList3[2];
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void SubtractAListFromAnotherList_CheckNewListCount()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 1;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(1);
            CustomList<int> myList3 = myList1 - myList2;
            actual = myList3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractAListFromAnotherList_CheckFirstIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 2;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);
            myList2.Add(1);
            CustomList<int> myList3 = myList1 - myList2;
            actual = myList1[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtactAListFromAnotherList_CheckLastIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 3;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);
            myList2.Add(1);
            CustomList<int> myList3 = myList1 - myList2;
            actual = myList1[1];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractAListFromAnotherList_CountTheSameAsFirstListIfSecondListEmpty()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 1;
            int actual;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(1);
            CustomList<int> myList3 = myList1 - myList2;
            actual = myList3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractAListFromAnotherList_ReportsAllItemsLeft()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected1 = 1;
            int expected2 = 2;
            int actual1;
            int actual2;
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            CustomList<int> myList3 = myList1 - myList2;
            actual1 = myList3[0];
            actual2 = myList3[1];
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void ZipTwoLists_ItemsInCorrectOrder()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            bool isTrue = default;
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = myList1.Zip(myList2);
            
            if (myList3[0] == myList1[0])
            {
                isTrue = true;
            }
            else if (myList3[1] == myList2[0])
            {
                isTrue = true;
            }
            else if (myList3[2] == myList1[1])
            {
                isTrue = true;
            }
            else if (myList3[3] == myList2[1])
            {
                isTrue = true;
            }
            else if (myList3[4] == myList1[2])
            {
                isTrue = true;
            }
            else if (myList3[5] == myList2[2])
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            Assert.IsTrue(isTrue);
        }
        
        [TestMethod]
        public void ZipTwoLists_CheckCount()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 6;
            int actual;
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = myList1.Zip(myList2);
            actual = myList3.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipTwoLists_CheckCapacity()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 8;
            int actual;
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = myList1.Zip(myList2);
            actual = myList3.Capacity;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipTwoLists_CheckFirstIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 1;
            int actual;
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = myList1.Zip(myList2);
            actual = myList3[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipTwoLists_CheckLastIndex()
        {
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            int expected = 6;
            int actual;
            myList1.Add(1);
            myList1.Add(3);
            myList1.Add(5);
            myList2.Add(2);
            myList2.Add(4);
            myList2.Add(6);
            CustomList<int> myList3 = myList1.Zip(myList2);
            actual = myList3[5];
            Assert.AreEqual(expected, actual);
        }

    }
}
