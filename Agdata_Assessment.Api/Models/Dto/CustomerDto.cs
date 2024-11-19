using System.ComponentModel.DataAnnotations;

namespace Agdata_Assessment.Api.Models.Dto
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime? CreatedDate { get; set; } //= default(DateTime?);
    }
}
