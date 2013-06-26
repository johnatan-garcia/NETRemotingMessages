using System;
using Messaging.Objects.Customer;
using Messaging.Server.Interface;

namespace Messaging.Server {
    
    class CustomerManager : MarshalByRefObject, ICustomerManager {
        
        public CustomerManager() {
            Console.WriteLine("CustomerManager.constructor: Object created");
        }
        
        public Customer GetCustomer(int id) {
            Console.WriteLine("CustomerManager.GetCustomer(): Called");
            Customer tmp = new Customer();
            tmp.FirstName = "John";
            tmp.LastName = "Doe";
            tmp.DateOfBirth = new DateTime(1970, 7, 4);
            Console.WriteLine("CustomerManager.GetCustomer(): Returning Customer-Object");
            return tmp;
        }

    }

}
