using Agdata_Assessment.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Agdata_Assessment.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
