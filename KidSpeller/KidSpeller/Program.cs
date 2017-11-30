using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidSpeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            string userWord = ConvertDigitToWord.DigitToWord(userNumber);

            Console.WriteLine($"User number in word: {userWord}");

            Console.ReadLine();
        }
    }
}
