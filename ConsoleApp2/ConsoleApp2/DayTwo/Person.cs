using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }

            public override string ToString()
            {
            return $"ID:{this.Id}, Name:{FirstName},{LastName},\n" +
                   $"Address:{Address},City:{City}, State:{Region},\n" +
                   $"Phone:{Phone},Country:{Country}, ZIP:{PostalCode}";


             }
    

    }
    internal class TestPerson
    {
         public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Aravind";
            firstPerson.LastName = "LN";
            firstPerson.Address = "OMR";
            firstPerson.City = "Chennai";
            firstPerson.Region = "TN";
            firstPerson.PostalCode = "600119";
            firstPerson.Country = "India";
            firstPerson.Title = "Mr";
            String value=firstPerson.ToString();
            Console.WriteLine(value);
        }
    }
}
