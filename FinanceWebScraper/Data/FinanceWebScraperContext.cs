using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinanceWebScraper.Models
{
    public class FinanceWebScraperContext : DbContext
    {
        public FinanceWebScraperContext (DbContextOptions<FinanceWebScraperContext> options)
            : base(options)
        {
        }

        public DbSet<FinanceWebScraper.Models.Stock> Stock { get; set; }
    }
}
