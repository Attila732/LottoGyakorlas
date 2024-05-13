using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;

namespace APIHatos.Data
{
    public class APIHatosContext : DbContext
    {
        public APIHatosContext (DbContextOptions<APIHatosContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrary.Models.Jatekos> Jatekos { get; set; } = default!;
        public DbSet<ClassLibrary.Models.Tipp> Tipp { get; set; } = default!;
    }
}
