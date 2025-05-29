using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Infrastructure
{
    public class CharityNetDbContextFactory : IDesignTimeDbContextFactory<CharityNetDbContext>
    {
        public CharityNetDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CharityNetDbContext>();

            optionsBuilder.UseSqlServer("Server=TELEMACHUS;Database=CharityNetDb;TrustServerCertificate=True;Trusted_Connection=True");

            return new CharityNetDbContext(optionsBuilder.Options);
        }
    }
}
