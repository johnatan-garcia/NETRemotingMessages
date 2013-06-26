using System;

namespace Messaging.Objects.Customer {
    
    [Serializable]
    public class Customer {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public Customer() {
            Console.WriteLine("Customer.constructor: Object created");
        }

        public int GetAge() {
            Console.WriteLine("Customer.GetAge(): Calculating age of {0}, " +
                              "born on {1}.",
                              FirstName,
                              DateOfBirth.ToShortDateString());
        
            TimeSpan tmp = DateTime.Today.Subtract(DateOfBirth);
            return tmp.Days / 365; // rough estimation
        }
    }
}