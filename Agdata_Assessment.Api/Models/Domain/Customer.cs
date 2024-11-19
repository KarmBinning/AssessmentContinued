using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Agdata_Assessment.Api.Models.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
