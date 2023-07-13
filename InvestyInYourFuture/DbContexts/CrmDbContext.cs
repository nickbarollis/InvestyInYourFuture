using InvestyInYourFuture.Models;
using Microsoft.EntityFrameworkCore;

namespace SqlAzureConnect.DbContexts
{
    public class CrmDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
        

        public CrmDbContext() { }
        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
        {
        }

    }
}