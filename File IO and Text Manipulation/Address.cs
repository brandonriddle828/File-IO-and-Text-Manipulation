using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_and_Text_Manipulation
{
    internal class Address
    {
        public string Street { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string ZipCode { get; init; }

        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return
                $"{Street}|{City}|{State}|{ZipCode}\n";

        }
    }
}
