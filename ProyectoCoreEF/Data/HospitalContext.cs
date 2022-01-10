using Microsoft.EntityFrameworkCore;
using ProyectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCoreEF.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options) { }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
