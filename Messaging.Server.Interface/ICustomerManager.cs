using Messaging.Objects.Customer;

namespace Messaging.Server.Interface {

    public interface ICustomerManager {
        Customer GetCustomer(int id);
    }

}
