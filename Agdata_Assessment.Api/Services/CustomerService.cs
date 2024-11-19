using Agdata_Assessment.Api.Models.Domain;

namespace Agdata_Assessment.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public IList<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(Customer customer)
        {
            _customers.Add(customer);

            return customer;
        }


        #region Future Feature Releases
        
        public Customer UpdateCustomer(Customer customer)
        {
            throw new NotSupportedException();
        }

        public Customer DeleteCustomer(Customer customer)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}
