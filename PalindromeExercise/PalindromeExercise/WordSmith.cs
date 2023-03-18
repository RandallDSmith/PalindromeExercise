﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var isPal = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                isPal += word[i];
            }
            if(isPal == word)
            {
                return true;
            }
            return false;
        }
    }
}
