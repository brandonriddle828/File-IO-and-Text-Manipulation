using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_and_Text_Manipulation
{
    internal class Person:IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }





        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
           
        }


        public override string ToString()
        {
            return
                $"{FirstName}|{LastName}|{Address}\n";
          
        }

        public int CompareTo(Person? other)
        {
            Person comparablePerson = other;

            return string.Compare(this.LastName, comparablePerson.LastName);
        }
    }

}
