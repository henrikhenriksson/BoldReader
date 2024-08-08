using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADHDReader.Classes
{
    public static class TextProcessor
    {

        public static List<string> ProcessText(string input)
        {
             //  var words = input.Split(' ').ToList();

            var words = Regex.Split(input, @"(\s+|\b)").ToList();


            return words;
        }

    }
}
