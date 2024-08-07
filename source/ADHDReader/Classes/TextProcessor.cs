using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADHDReader.Classes
{
    public static class TextProcessor
    {

        public static String ProcessText(string input)
        {
            var words = input.Split(' ');
            var processedWords= words.Select(FormatWord);
            return string.Join(" ", processedWords);
        }


        private static string FormatWord(string word)
        {
            if (word.Length <= 4)
            {
                return Bolden(word, 1, word.Length - 2);


            } else
            {
                return Bolden(word, 2, word.Length - 3);
            }
        }

        private static string Bolden(string word, int startBold, int endBold)
        {
            if (word.Length > startBold + endBold + 1)
            {
                return word;
            }

            var boldStart = word.Substring(0, startBold);
            var boldEnd = word.Substring(word.Length - endBold);
            var middle = word.Substring(startBold, word.Length - (startBold + endBold));

            return $"<b>{boldStart}</b>{middle}<b>{boldEnd}</b>"; ;
        }

    }
}
