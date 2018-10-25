using System;
using Microsoft.EntityFrameworkCore;
using My_Bank_API.Models;

namespace My_Bank_API.DataAccess
{
    public class MyBankDbContext : DbContext
    {

        public MyBankDbContext()
        {

        }

        public MyBankDbContext(DbContextOptions<MyBankDbContext> Users)
            : base(Users)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<TransactionHistory> TransactionHistory { get; set; }
    }
}
