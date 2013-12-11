using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class TestCase
    {
        private int[] array;
        private int sn;
        private int s;
        private int e;
        private int sr;

       public TestCase(int[] A, int searchNumber, int start, int end, int searchResult)
        {
            this.array = A;
            this.sn = searchNumber;
            this.s = start;
            this.e = end;
            this.sr = searchResult;
        }

        public  string ExecuteTestCase()
        {
            if (sr == Search.NumberSearch(array, sn, s, e))
            {
                return "Pass";
            }
            else
            {
                return "Failed";
            }
            
        }
    }
}
