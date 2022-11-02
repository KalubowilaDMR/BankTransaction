using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BankTransaction.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext>options) : base(options)
        {
            
        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
