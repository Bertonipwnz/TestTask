using Microsoft.EntityFrameworkCore;


namespace TestTaskUWP.Models
{
    class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
      
    
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=Test.db");
            base.OnConfiguring(options);
        }
        
    }
}
