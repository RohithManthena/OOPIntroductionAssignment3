using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntroduction
{
    class Person
    {
        public string firstName;
        public string lastName;
        public static string salutationMr = "Mr";
        public string getName()
        {
            return firstName + " " + lastName;
        }
        public Person()
        {
            firstName = "Elon";
            lastName = "Musk";
        }
        public void PersonLastName(string lname)
        {
            lastName = lname;
            Console.WriteLine(lastName);
        }
    }
}
