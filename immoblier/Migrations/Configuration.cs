namespace immoblier.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using immoblier.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<immoblier.DAL.AgenceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(immoblier.DAL.AgenceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var typeBiens = new List<TypeBien> {
            new TypeBien{Libelle="Terrain"},
            new TypeBien{Libelle="Maison"},
            new TypeBien{Libelle="Appartements"},
            new TypeBien{Libelle="Studios"},
            new TypeBien{Libelle="Etrepos"},
            new TypeBien{Libelle="Depos"},
            new TypeBien{Libelle="Magasins"}
            };
            typeBiens.ForEach(c => context.typeBiens.AddOrUpdate(tb => tb.Libelle, c));
            context.SaveChanges();
            var typeContrat = new List<TypeContrat>
            {
                new TypeContrat{Libelle="Achat"},
                new TypeContrat{Libelle="Vente"},
                new TypeContrat{Libelle="Location"}
            };
            typeContrat.ForEach(c => context.typeContrats.AddOrUpdate(tc => tc.Libelle, c));
            context.SaveChanges();
           var agences = new List<Agence>
            {
                new Agence{adresse="Medina 25x22", NomResponsable="Momodou Dia"},
            };
            agences.ForEach(c => context.agences.AddOrUpdate(ag => ag.NomResponsable, c));
            context.SaveChanges();
        }
    }
}
