// Read a first name from the console
// Print the name one letter at a time, one letter per line
// Read a last name from the console
// Print the name one letter at a time with spaces between each letter

using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            var firstName = Console.ReadLine();

            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Enter your last name");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());

            //
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            if (hasMiddleName == "y")
            {
                Console.WriteLine("Enter your middle name");
                var middleName = Console.ReadLine();

                var i = 0;
                foreach (var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine("KKKK");
            }

            Console.WriteLine("Exit");
            Console.ReadLine();
        }
    }
}
