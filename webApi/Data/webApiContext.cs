using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApi.Models;

namespace webApi.Data
{
    public class webApiContext : DbContext
    {
        public webApiContext (DbContextOptions<webApiContext> options)
            : base(options)
        {
        }

        public DbSet<webApi.Models.Usuarios> Usuarios { get; set; }

        public DbSet<webApi.Models.Roles> Roles { get; set; }

        public DbSet<webApi.Models.Permisos> Permisos { get; set; }
    }
}
