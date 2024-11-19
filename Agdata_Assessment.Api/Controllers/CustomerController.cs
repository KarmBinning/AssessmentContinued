using Agdata_Assessment.Api.Data;
using Agdata_Assessment.Api.Models.Domain;
using Agdata_Assessment.Api.Models.Dto;
using Agdata_Assessment.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agdata_Assessment.Api.Controllers
{
    // https://localhost:.../api/customer
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region COMMENTED EFC Code
        //private readonly AppDbContext dbContext;

        //public CustomerController(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        #endregion

        //private readonly ICustomerService _customerService;

        //public CustomerController(ICustomerService customerService)
        //{
        //    _customerService = customerService;
        //}
        List<Customer> customers = new List<Customer>();

        private List<Customer> GetCustomers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Customer customer = new Customer();
                customer.Name = "name" + i.ToString();
                customer.Address = "address" + i.ToString();
                customer.CreatedDate = DateTime.Now;

                customers.Add(customer);
                Console.WriteLine(customer.ToString());
            }

            return customers;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            customers = GetCustomers();

            if (ModelState.IsValid)
            {
                // Domain model to DTO
                //var response = new CustomerDto
                //{
                //    Name = customer.Name,
                //    Address = customer.Address,
                //    CreatedDate = customer.CreatedDate
                //};

                var response = customers.ToArray();

                return Ok(response);
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerDto request)
        {
            // Map CreateCustomerDto to domain Customer model
            var customer = new Customer
            {
                Name = request.Name,
                Address = request.Address,
                CreatedDate = DateTime.Now
            };

            if (ModelState.IsValid)
            {
                #region COMMENTED EFC Code
                //await dbContext.Customers.AddAsync(customer);
                //await dbContext.SaveChangesAsync();
                #endregion

                // Domain model to DTO
                var response = new CustomerDto
                {
                    Name = customer.Name,
                    Address = customer.Address,
                    CreatedDate = customer.CreatedDate
                };

                return Ok(response);
            }

            return BadRequest(ModelState);
        }


        #region Extracted Methods
        #endregion
    }
}
