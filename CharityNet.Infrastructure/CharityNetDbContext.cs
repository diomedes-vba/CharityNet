using CharityNet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Infrastructure
{
    public class CharityNetDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CharityCampaign> CharityCampaigns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TELEMACHUS;Database=CharityNetDb;TrustServerCertificate=True;Trusted_Connection=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
