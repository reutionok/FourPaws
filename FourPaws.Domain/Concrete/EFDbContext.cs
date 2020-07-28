using FourPaws.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPaws.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
