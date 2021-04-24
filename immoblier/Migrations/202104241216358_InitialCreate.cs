namespace immoblier.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agence",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        adresse = c.String(nullable: false, maxLength: 80),
                        NomResponsable = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contrat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10),
                        Montant = c.Int(),
                        MontantMensuel = c.Int(),
                        DateSignature = c.DateTime(nullable: false),
                        DateDebut = c.DateTime(),
                        DateFin = c.DateTime(),
                        ClientID = c.Int(),
                        BailleurID = c.Int(),
                        AgenceID = c.Int(nullable: false),
                        Bien_Id = c.Int(),
                        TypeContrat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agence", t => t.AgenceID, cascadeDelete: true)
                .ForeignKey("dbo.Bailleur", t => t.BailleurID)
                .ForeignKey("dbo.Client", t => t.ClientID)
                .ForeignKey("dbo.Bien", t => t.Bien_Id)
                .ForeignKey("dbo.TypeContrat", t => t.TypeContrat_Id)
                .Index(t => t.ClientID)
                .Index(t => t.BailleurID)
                .Index(t => t.AgenceID)
                .Index(t => t.Bien_Id)
                .Index(t => t.TypeContrat_Id);
            
            CreateTable(
                "dbo.Bailleur",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 20),
                        Prenom = c.String(nullable: false, maxLength: 40),
                        Telephone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(maxLength: 20),
                        adresse = c.String(maxLength: 80),
                        genre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNI = c.String(nullable: false, maxLength: 20),
                        Nom = c.String(nullable: false, maxLength: 25),
                        Prenom = c.String(nullable: false, maxLength: 40),
                        Telephone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 25),
                        genre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bien",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        lieu = c.String(nullable: false, maxLength: 80),
                        garniture = c.Boolean(nullable: false),
                        statut = c.Int(),
                        etat = c.Int(),
                        Detail = c.String(maxLength: 255),
                        TypeBien_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeBien", t => t.TypeBien_Id)
                .Index(t => t.TypeBien_Id);
            
            CreateTable(
                "dbo.TypeBien",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeContrat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrat", "TypeContrat_Id", "dbo.TypeContrat");
            DropForeignKey("dbo.Bien", "TypeBien_Id", "dbo.TypeBien");
            DropForeignKey("dbo.Contrat", "Bien_Id", "dbo.Bien");
            DropForeignKey("dbo.Contrat", "ClientID", "dbo.Client");
            DropForeignKey("dbo.Contrat", "BailleurID", "dbo.Bailleur");
            DropForeignKey("dbo.Contrat", "AgenceID", "dbo.Agence");
            DropIndex("dbo.Bien", new[] { "TypeBien_Id" });
            DropIndex("dbo.Contrat", new[] { "TypeContrat_Id" });
            DropIndex("dbo.Contrat", new[] { "Bien_Id" });
            DropIndex("dbo.Contrat", new[] { "AgenceID" });
            DropIndex("dbo.Contrat", new[] { "BailleurID" });
            DropIndex("dbo.Contrat", new[] { "ClientID" });
            DropTable("dbo.TypeContrat");
            DropTable("dbo.TypeBien");
            DropTable("dbo.Bien");
            DropTable("dbo.Client");
            DropTable("dbo.Bailleur");
            DropTable("dbo.Contrat");
            DropTable("dbo.Agence");
        }
    }
}
