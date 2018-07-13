namespace Y2K.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateReservationFieldsWithRelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "CityId_Id", "dbo.Cities");
            DropIndex("dbo.Reservations", new[] { "CityId_Id" });
            RenameColumn(table: "dbo.Reservations", name: "CityId_Id", newName: "CityId");
            AlterColumn("dbo.Reservations", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Reservations", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Reservations", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Reservations", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "CityId");
            AddForeignKey("dbo.Reservations", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CityId", "dbo.Cities");
            DropIndex("dbo.Reservations", new[] { "CityId" });
            AlterColumn("dbo.Reservations", "CityId", c => c.Int());
            AlterColumn("dbo.Reservations", "Email", c => c.String());
            AlterColumn("dbo.Reservations", "LastName", c => c.String());
            AlterColumn("dbo.Reservations", "Nombre", c => c.String());
            RenameColumn(table: "dbo.Reservations", name: "CityId", newName: "CityId_Id");
            CreateIndex("dbo.Reservations", "CityId_Id");
            AddForeignKey("dbo.Reservations", "CityId_Id", "dbo.Cities", "Id");
        }
    }
}
