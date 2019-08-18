using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        

        
        [TestCase(15,15,0,0,ExpectedResult =15)]
        [TestCase(8, 15, 0, 0,ExpectedResult =9)]
        [TestCase(8, 15, 3, 8,ExpectedResult =120)]
        public int InsertNumberTests(int a,int b,int c,int d)
        {
            int expResult = ConsoleApp1.Tasks.InsertNumber(a, b, c, d);
            return expResult;
        }


        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]

        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1233421)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3445632)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumberTests(int a)
        {
            int expResult = ConsoleApp1.Tasks.FindNextBiggerNumber(a.ToString());
            return expResult;
        }
        [TestCase('7',"1,2,3,4,5,6,7,68,69,70,15,17")]
        public void FilterDigitTest(char a,string b)
        {
            List<int> expResult=new List<int>(new[]{ 7,70,17});
            List<int> Result = ConsoleApp1.Tasks.FilterDigit(a,b);
            Assert.That(expResult, Is.EquivalentTo(Result)); ;
        }
    }
}