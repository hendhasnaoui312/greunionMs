using Chaufferie.ChargesMS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chaufferie.ChargeMS.Data.Context
{
    public class ChargesContext : DbContext
    {
        public ChargesContext(DbContextOptions<ChargesContext> options)
            : base(options)
        {
        }


        public DbSet<Réunion> Réunions { get; set; }
        public DbSet<Reunion_aprés_cloture> Reunion_aprés_cloture { get; set; }
        public DbSet<Reunion_avant_cloture> Reunion_avant_cloture { get; set; }
        public DbSet<TypeReunion> TypeReunion { get; set; }
        public DbSet<TypeReunion_sous_service> TypeReunion_sous_service { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      

        }


    }
}
