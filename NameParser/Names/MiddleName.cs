using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName
    {
        // set the inital property to be empty
        public string Name { get; private set; } = "";

        private bool ConfirmMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            // if condition
            return hasMiddleName == "y";
        }

        public void GetMiddleName(string firstName)
        {
            if (ConfirmMiddleName())
            {
                Console.WriteLine("Enter your middle name");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"{firstName}, that is fine");
            }
        }

        public void PrintMiddleName()
        {
            var i = 0;
            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
