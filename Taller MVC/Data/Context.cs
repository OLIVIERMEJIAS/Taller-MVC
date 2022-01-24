using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller_MVC.Models;

namespace Taller_MVC.Data
{
    public class Context: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Consulta> Consulta { get; set; }

        public Context(DbContextOptions<Context> options): base(options)
        {

        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //}

    }
}
