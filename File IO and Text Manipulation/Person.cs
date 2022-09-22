using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_and_Text_Manipulation
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }





        public override string ToString()
        {
            return
                $"First Name        {FirstName} " +
                $"Last Name         {LastName}" +
                $"Address           {Address}" +
                $"Phone             {Phone}";
        }
    }

}
