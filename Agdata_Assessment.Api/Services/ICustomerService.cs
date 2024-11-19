using Agdata_Assessment.Api.Models.Domain;

namespace Agdata_Assessment.Api.Services
{
    public interface ICustomerService
    {
        // Show ALL of the Customer list
        IList<Customer> GetCustomers();

        // This will create a Customer object and return the new Customer
        Customer CreateCustomer(Customer customer);
    }
}
