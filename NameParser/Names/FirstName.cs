using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class FirstName
    {

        // version 1
        //public string GetFirstName()
        //{
        //    Console.WriteLine("Enter your first name");
        //    var firstName = Console.ReadLine();
        //    return firstName;
        //}

        //public void PrintFirstName(string firstName)
        //{
        //    foreach (var letter in enteredFirstName)
        //    {
        //        Console.WriteLine(letter);
        //    }
        //}

        // version 2
        //private string _firstname;

        //public void GetFirstName()
        //{
        //    Console.WriteLine("enter your first name");
        //    _firstname = Console.ReadLine();
        //}

        //public void PrintFirstName()
        //{
        //    foreach (var letter in _firstname)
        //    {
        //        Console.WriteLine(letter);
        //    }
        //}

        // version 3
        public string Name { get; private set; }

        public void GetFirstName()
        {
            Console.WriteLine("enter your first name");
            Name = Console.ReadLine();
        }

        public void PrintFirstName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
