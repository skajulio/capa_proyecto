namespace Y2K.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forstRun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        CityId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId_Id)
                .Index(t => t.CityId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CityId_Id", "dbo.Cities");
            DropIndex("dbo.Reservations", new[] { "CityId_Id" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Cities");
        }
    }
}
