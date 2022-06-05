using Microsoft.EntityFrameworkCore;
using TestTaskUWP.Models;

namespace TestTaskUWP.Data
{
    class TransactionContext : DbContext
    {
        
        public DbSet<Transaction> Transactions { get; set; }
    
        //Создание табл
       /* public TransactionContext()
        {
            Database.EnsureCreated();
        }*/
      
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=TestTransactions.db");
            base.OnConfiguring(options);
        }
        
    }
}
