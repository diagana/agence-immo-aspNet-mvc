using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using immoblier.Models;

namespace immoblier.DAL
{
    public class AgenceContext:DbContext
    {
        public AgenceContext():base("AgenceContext"){
            }
        public DbSet<Contrat> contrats { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Bien> biens { get; set; }
        public DbSet<Bailleur> bailleurs { get; set; }
        public DbSet<Agence> agences { get; set; }
        public DbSet<TypeContrat> typeContrats { get; set; }
        public DbSet<TypeBien> typeBiens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}