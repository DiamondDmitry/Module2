using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Extensions
{
    public static class StringWordsCountExtension
    {
        public static int CountWordsInString(this string stringToCount)
        {
            string[] wordsArray = stringToCount.Split(' ');
            return wordsArray.Length;
        }

    }
} 
