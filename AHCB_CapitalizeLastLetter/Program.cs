using System;

namespace AHCB_CapitalizeLastLetter
{
    class Program
    {
        static public string AcceptUserInput()
        {
            Console.WriteLine("Enter some text, please.");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static public string CapitalizeLastLetter(string userInput)
        {
            int lastLetterIndex = userInput.Length - 1;
            string allButLastLetter = userInput.Substring(0, lastLetterIndex);
            string lastLetterCaps = userInput[lastLetterIndex].ToString().ToUpper();
            string capitalizeLastLetter = $"{allButLastLetter}{lastLetterCaps}";
            return capitalizeLastLetter;
        }

        static void Main(string[] args)
        {
            string userInput = AcceptUserInput();

            Console.WriteLine($"Original: {userInput}");

            string capitalizeLastLetter = CapitalizeLastLetter(userInput);

            Console.WriteLine($"After function: {capitalizeLastLetter}");
        }
    }
}
