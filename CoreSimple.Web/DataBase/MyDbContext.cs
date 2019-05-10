using CoreSimple.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSimple.Web.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<BillsItem> BillsItems { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
