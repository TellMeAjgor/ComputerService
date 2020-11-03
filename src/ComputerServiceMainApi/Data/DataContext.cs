using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerServiceModels.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComputerServiceMainApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Computer> Computers { get; set; }
    }
}
