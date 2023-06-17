using ImportedCSharpLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp70
{
    public class Discards
    {
        public static void Play()
        {
            var p = new CityPerson("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}!");
            // The example displays the following output:
            //      Hello John of Boston!
        }

        public static void Play2()
        {
            string[] dateStrings = {"05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT" };
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out _))
                    Console.WriteLine($"'{dateString}': valid");
                else
                    Console.WriteLine($"'{dateString}': invalid");
            }
        }

        public static void Method(string arg)
        {
            _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");

            // Do work with arg.
        }
    }

    public class CityPerson : Person
    {
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public CityPerson(string fname, string mname, string lname,
                      string cityName, string stateName)
            :base(fname, lname)
        {
            MiddleName = mname;
            City = cityName;
            State = stateName;
        }

        // Return the first and last name.
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname,
                                out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
}
