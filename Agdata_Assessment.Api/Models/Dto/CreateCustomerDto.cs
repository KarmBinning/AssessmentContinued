using System.ComponentModel.DataAnnotations;

namespace Agdata_Assessment.Api.Models.Dto
{
    public class CreateCustomerDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
