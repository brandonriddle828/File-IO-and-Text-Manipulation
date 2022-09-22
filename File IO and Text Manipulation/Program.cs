using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_and_Text_Manipulation
{
    public class Program
    {
        FileRoot root;
        StreamReader reader;
        StreamWriter writer;


        public static void Main(string[] args)
        {

          Program p = new Program();

            p.GetData();

        }

        public void GetData()
        {

            var root = FileRoot.projectRoot;
            char dirSep = Path.DirectorySeparatorChar;
            var file = root + dirSep + "Data" + dirSep + "data.csv";
            var newFile = root + dirSep + "Data" + dirSep + "data.psv";

            var people = new List<Person>();


            using (reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var info = line.Split(",");

                    // getting person information
                    var fName = info[0];
                    var lName = info[1];
                    var street = info[2];
                    var city = info[3];
                    var state = info[4];
                    var zipcode = info[5];


                    
                    Address address = new Address(street, city, state, zipcode);
                    // create object & add it to the collection
                    people.Add(new Person(fName, lName, address));

                    people.Sort();
                }
            }

            using (writer = new StreamWriter(newFile, append: false))
            {
                foreach (Person p in people)
                {
                    string line = $"{p.FirstName}|{p.LastName}|{p.Address}";
                    writer.WriteLine(line);
                }
                Console.WriteLine();
                Console.WriteLine("Writing people data to new file.....");
            }

        }
        
    }
}
