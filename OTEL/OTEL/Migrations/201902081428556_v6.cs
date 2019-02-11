namespace OTEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rezervasyonlar", "KisiSayisi", c => c.Short(nullable: false));
            AddColumn("dbo.Rezervasyonlar", "CheckIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rezervasyonlar", "CheckOut", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rezervasyonlar", "KisiSayi");
            DropColumn("dbo.Rezervasyonlar", "ChenkIn");
            DropColumn("dbo.Rezervasyonlar", "ChenkOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezervasyonlar", "ChenkOut", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rezervasyonlar", "ChenkIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rezervasyonlar", "KisiSayi", c => c.Short(nullable: false));
            DropColumn("dbo.Rezervasyonlar", "CheckOut");
            DropColumn("dbo.Rezervasyonlar", "CheckIn");
            DropColumn("dbo.Rezervasyonlar", "KisiSayisi");
        }
    }
}
