using System.Data.Entity;
//
using MVCDemo.Models;

namespace MVCDemo.ModelsDbConext
{
    public class TFundDbContext:DbContext
    {
        public DbSet<TFund> fFunds { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("POSUSR");  //must be UPPERCASE_SCHEMA_NAME
        }
    }
    
}