using EstimaTEE.Data;
using EstimaTEE.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.Factories
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args = null)
        {
            var dataService = new DataService();
            var conString = dataService.GetConnectionString();
            var options = new DbContextOptionsBuilder<AppDbContext>();

            options.UseNpgsql(conString);

            return new AppDbContext(options.Options);
        }
    }
}
