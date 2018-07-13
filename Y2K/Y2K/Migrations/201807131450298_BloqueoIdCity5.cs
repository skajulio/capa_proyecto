namespace Y2K.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BloqueoIdCity5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdExternal = c.Int(nullable: false),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdExternal = c.Int(nullable: false),
                        Main = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weathers");
            DropTable("dbo.Cities");
        }
    }
}
