using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayEight
{
    [Serializable]
     class Customer
    {
        private readonly double Id;
        public string Title = String .Empty;
        public string FirstName {  get; set; }= String .Empty;
        public string LastName { get; set; } = String .Empty;
        public double CreditLimit { get; set; }
        public Customer(double v1) { Id = v1; }
        public double GetID() { return Id; }
        public override string ToString()
        {
            return $"Details: {Id}{FirstName} {LastName} {CreditLimit}";
        }
    }
}
