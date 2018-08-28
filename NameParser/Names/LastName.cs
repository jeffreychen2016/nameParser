using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class LastName
    {
        public string Name { get; private set; }

        public void GetLastName()
        {
            Console.WriteLine("Enter your last name");
            Name = Console.ReadLine();
        }

        public void PrinLastName()
        {
            var lastNameWithSpaces = "";

            foreach (var letter in Name.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());
        }
    }
}
