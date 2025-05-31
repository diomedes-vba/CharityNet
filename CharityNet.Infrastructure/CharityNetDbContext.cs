using CharityNet.Domain.Entities;
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
        
        public CharityNetDbContext(DbContextOptions<CharityNetDbContext> options) : base(options) { }
    }
}
