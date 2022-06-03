using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTaskUWP.Models;

namespace TestTaskUWP.ViewModels
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
