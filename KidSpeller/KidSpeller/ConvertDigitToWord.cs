using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidSpeller
{
    public class ConvertDigitToWord
    {
        public static string DigitToWord(int number)
        {
            var word = "";

            switch (number)
            {
                case 0: word = "Zero";
                    break;
                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
            }

            return word;
        }
    }
}
