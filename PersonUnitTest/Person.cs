using System;
namespace PersonUnitTest
{
    internal class Person
    {
        string firstName;
        string lastName;
        public string FirstName {
            get { 
                return firstName; 
            }
        }

        public string LastName { 
            get { 
                return lastName; 
            } 
        }

        public Person(string v1, string v2)
        {
            firstName = v1;
            lastName = v2;
        }
    }
}