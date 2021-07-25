using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoTreinoAspNet.Models;

namespace ProjetoTreinoAspNet.Data
{
    public class ProjetoTreinoAspNetContext : DbContext
    {
        public ProjetoTreinoAspNetContext (DbContextOptions<ProjetoTreinoAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
