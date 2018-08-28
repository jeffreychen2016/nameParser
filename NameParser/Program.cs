// Read a first name from the console
// Print the name one letter at a time, one letter per line
// Read a last name from the console
// Print the name one letter at a time with spaces between each letter

using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //version 1
            // get first name and print it out
            //var firstName = new FirstName(); // instanciate the class
            //var enteredFirstName = firstName.GetFirstName();
            //firstName.PrintFirstName(enteredFirstName);

            var firstName = new FirstName();
            firstName.GetFirstName();
            firstName.PrintFirstName();


            var lastName = new LastName();
            lastName.GetLastName();
            lastName.PrinLastName();

            var middleName = new MiddleName();
            middleName.GetMiddleName(firstName.Name);
            middleName.PrintMiddleName();

            Console.WriteLine("Exit");
            Console.ReadLine();
        }
    }
}
