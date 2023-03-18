using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("orange", false)]
        [InlineData("hello", false)]
        [InlineData("noon", true)]

            public void PalindromeTester(string input, bool expected)
            {
                WordSmith tester = new WordSmith();
               
                var actual = tester.IsAPalindrome(input);

                Assert.Equal(expected, actual);
            }



        
    }
}
