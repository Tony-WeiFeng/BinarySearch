using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class Search
    {
        static void Main(string[] args)
        {
           //Testcase_01: Array is null.
            int[] Arr = null;
            TestCase testcase_01 = new TestCase(Arr, 5, 0, 10, -1);
            Console.WriteLine("The test result of Testcase_01 is " + testcase_01.ExecuteTestCase());

            //Testcase_02: Array length is 0.
            Arr = new int[0];
            int maxIndex = Arr.Length - 1;
            TestCase testcase_02 = new TestCase(Arr, 5, 0, maxIndex, -1);
            Console.WriteLine("The test result of Testcase_02 is " + testcase_02.ExecuteTestCase());

            //Testcase_03:  Only one element in the Array and it's not equal to the  search number.
            Arr = new int[] {0};
            maxIndex = Arr.Length - 1;
            TestCase testcase_03 = new TestCase(Arr, 5, 0, maxIndex, -1);
            Console.WriteLine("The test result of Testcase_03 is " + testcase_03.ExecuteTestCase());

            //Testcase_04: Only one element in the Array and it's equal to the  search number.
            Arr = new int[] { 5 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_04 = new TestCase(Arr, 5, 0, maxIndex, 0);
            Console.WriteLine("The test result of Testcase_04 is " + testcase_04.ExecuteTestCase());

            //Testcase_05: Two elements in the Array and they are not equal to the  search number.
            Arr = new int[] { 3, 4 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_05 = new TestCase(Arr, 5, 0, maxIndex, -1);
            Console.WriteLine("The test result of Testcase_05 is " + testcase_05.ExecuteTestCase());

            //Testcase_06: Two elements in the Array and one of them is equal to the  search number.
            Arr = new int[] { 4, 5 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_06 = new TestCase(Arr, 5, 0, maxIndex, 1);
            Console.WriteLine("The test result of Testcase_06 is " + testcase_06.ExecuteTestCase());

            //Testcase_07: Two elements in the Array and they are all equal to the  search number. 
            //This case is not fit for test the BinarySearch funcation,  because we  suppose the Array is an ascending array.
            //But this one and {5, 5, 5}, seems they are especial negetive cases, so list it here.
            Arr = new int[] { 5, 5 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_07 = new TestCase(Arr, 5, 0, maxIndex, 0);
            Console.WriteLine("The test result of Testcase_07 is " + testcase_07.ExecuteTestCase());

            //Testcase_08: Three elements in the Array and they are not equal to the  search number.
            Arr = new int[] {1, 2, 4};
            maxIndex = Arr.Length - 1;
            TestCase testcase_08 = new TestCase(Arr, 5, 0, maxIndex, -1);
            Console.WriteLine("The test result of Testcase_08 is " + testcase_08.ExecuteTestCase());

            //Testcase_09: Three elements in the Array and the middle one is equal to the  search number.
            Arr = new int[] { 4, 5, 6 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_09 = new TestCase(Arr, 5, 0, maxIndex, 1);
            Console.WriteLine("The test result of Testcase_09 is " + testcase_09.ExecuteTestCase());

            //Testcase_10: More than three elements in the Array and the first one is equal to the  search number.
            Arr = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_10 = new TestCase(Arr, 5, 0, maxIndex, 0);
            Console.WriteLine("The test result of Testcase_10 is " + testcase_10.ExecuteTestCase());

            //Testcase_11: More than three elements in the Array and the last one is equal to the  search number.
            Arr = new int[] { 1, 2, 3, 4, 5 };
            maxIndex = Arr.Length - 1;
            TestCase testcase_11 = new TestCase(Arr, 5, 0, maxIndex, 4);
            Console.WriteLine("The test result of Testcase_11 is " + testcase_11.ExecuteTestCase());

            Console.ReadLine();
         }

         public static int NumberSearch(int[] sortedArray, int searchNum, int start, int end)
         {
             // Arrat is null or empty
             if (sortedArray == null || sortedArray.Length == 0 || start > end)
             {
                 //Console.WriteLine("Array is empty or null!");
                 return -1;
             }
             if (start == end)
             {
                 if (searchNum == sortedArray[start])
                 {
                     return start;
                 }
                 else
                 {
                     //Console.WriteLine("Number not found!");
                     return -1;
                 }
             }
             if (start == end - 1)
             {

                 if (searchNum == sortedArray[start])
                 {
                     return start;
                 }

                 if (searchNum == sortedArray[end])
                 {
                     return end;
                 }

                 else
                 {
                     //Console.WriteLine("Number not found!");
                     return -1;
                 }
                 
             }

             else
             {
                 int mid = (start + end) / 2;
                 if (searchNum == sortedArray[mid])
                 {
                     return mid;
                 }
                else if (searchNum < sortedArray[mid])
                 {
                     end = mid;
                     return NumberSearch(sortedArray, searchNum, start, end);
                 }
                 else
                 {
                     start = mid;
                     return NumberSearch(sortedArray, searchNum, start, end);
                 }
             }
         }
    }
}
