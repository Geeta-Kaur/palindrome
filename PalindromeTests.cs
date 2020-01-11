using System;
using NUnit.Framework;

namespace Palindrome
{
    public class Tests
    {

        ///Test 1 (palindrome)
        [Test]
        public void Test1_String_Palindrome_Returns_True()
        {
            Assert.IsTrue(IsPalindrome("noon"));
        }

        ///Test 2 (null or empty)
        [TestCase(null)]
        [TestCase(" ")]
        public void Test2_NullorEmpty_Parameter_Throws_ArgumentNullException(string strInput)
        {
            Assert.Throws<ArgumentNullException>(() => IsPalindrome(strInput));
        }

        ///Test 3 (non palindrome)
        [Test]
        public void Test3_NonPalindrome_Parameter_Returns_False()
        {
            Assert.IsFalse(IsPalindrome("day"));

        }

        /// Implementation method
        private bool IsPalindrome(string testStr)
        {
            //Passes all 4 test cases
            if (String.IsNullOrWhiteSpace(testStr))
                throw new ArgumentNullException(nameof(testStr));

            char[] strArray = testStr.ToCharArray();
            Array.Reverse(strArray);
            return (testStr == new string(strArray));

            /*
            //step 8 - refactored and passed both null and empty string params validation: Test2
                if(String.IsNullOrWhiteSpace(testStr))
                    throw new ArgumentNullException(nameof(testStr));

                char[] strArray = testStr.ToCharArray();
                    Array.Reverse(strArray);               
                    return (testStr == new string(strArray));
            
            */

            /*
            //step 7 - failed validation for empty string :Test2
                if(testStr == null)
                    throw new ArgumentNullException(nameof(testStr));

                char[] strArray = testStr.ToCharArray();
                    Array.Reverse(strArray);               
                    return (testStr == new string(strArray));
            */

            /*
            //step 6 - refactor to successful test for null validation :Test2
                if(testStr == null)
                    throw new ArgumentNullException(nameof(testStr));

                char[] strArray = testStr.ToCharArray();
                    Array.Reverse(strArray);               
                    return (testStr == new string(strArray));
            */


            /*
            //step 5 - test for null parameter null validation fail Test2
                char[] strArray = testStr.ToCharArray();
                Array.Reverse(strArray);               
                return (testStr == new string(strArray));
            
            */

            /* 
           //step 4 - refactor code of step 3 and ran successful Test1
                char[] strArray = testStr.ToCharArray();
                Array.Reverse(strArray);               
                return (testStr == new string(strArray));
            */
            /* 
            //step 3- implementation of palindrome for successful Test1
                 char[] strArray = testStr.ToCharArray();
                 Array.Reverse(strArray);
                 string reversedStr = new string(strArray);
                 return (testStr == reversedStr);
            */
            //return true; -- step 2 passed test of Test1
            //throw new NotImplementedException(); -- step 1 failed test of Test1
        }
    }
}