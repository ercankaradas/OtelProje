namespace OTEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Odalar", "Oteller_ID", "dbo.Oteller");
            DropForeignKey("dbo.Rezervasyonlar", "musteri_ID", "dbo.Musteriler");
            DropForeignKey("dbo.Rezervasyonlar", "oda_ID", "dbo.Odalar");
            DropIndex("dbo.Odalar", new[] { "Oteller_ID" });
            DropIndex("dbo.Rezervasyonlar", new[] { "musteri_ID" });
            DropIndex("dbo.Rezervasyonlar", new[] { "oda_ID" });
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Ilceler", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Mahalleler", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Iller", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Musteriler", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Musteriler", "TCKN", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Musteriler", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Odalar", "OdaNo", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Odalar", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Odalar", "Oteller_ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Oteller", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Yildizlar", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Yorumlar", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Ozellikler", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OtelResimleri", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisiID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "musteri_ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "oda_ID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Musteriler", "Email", unique: true);
            CreateIndex("dbo.Musteriler", "TCKN", unique: true);
            CreateIndex("dbo.Odalar", "Oteller_ID");
            CreateIndex("dbo.Oteller", "VergiNo", unique: true);
            CreateIndex("dbo.Rezervasyonlar", "musteri_ID");
            CreateIndex("dbo.Rezervasyonlar", "oda_ID");
            AddForeignKey("dbo.Odalar", "Oteller_ID", "dbo.Oteller", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Rezervasyonlar", "musteri_ID", "dbo.Musteriler", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Rezervasyonlar", "oda_ID", "dbo.Odalar", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyonlar", "oda_ID", "dbo.Odalar");
            DropForeignKey("dbo.Rezervasyonlar", "musteri_ID", "dbo.Musteriler");
            DropForeignKey("dbo.Odalar", "Oteller_ID", "dbo.Oteller");
            DropIndex("dbo.Rezervasyonlar", new[] { "oda_ID" });
            DropIndex("dbo.Rezervasyonlar", new[] { "musteri_ID" });
            DropIndex("dbo.Oteller", new[] { "VergiNo" });
            DropIndex("dbo.Odalar", new[] { "Oteller_ID" });
            DropIndex("dbo.Musteriler", new[] { "TCKN" });
            DropIndex("dbo.Musteriler", new[] { "Email" });
            AlterColumn("dbo.Rezervasyonlar", "oda_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "musteri_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.OtelResimleri", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(maxLength: 30));
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yorumlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yildizlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Odalar", "Oteller_ID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Odalar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Odalar", "OdaNo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Musteriler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Musteriler", "TCKN", c => c.String(maxLength: 11));
            AlterColumn("dbo.Musteriler", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String(maxLength: 20));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(maxLength: 20));
            AlterColumn("dbo.Iller", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mahalleler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(maxLength: 40));
            AlterColumn("dbo.Ilceler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(maxLength: 40));
            CreateIndex("dbo.Rezervasyonlar", "oda_ID");
            CreateIndex("dbo.Rezervasyonlar", "musteri_ID");
            CreateIndex("dbo.Odalar", "Oteller_ID");
            AddForeignKey("dbo.Rezervasyonlar", "oda_ID", "dbo.Odalar", "ID");
            AddForeignKey("dbo.Rezervasyonlar", "musteri_ID", "dbo.Musteriler", "ID");
            AddForeignKey("dbo.Odalar", "Oteller_ID", "dbo.Oteller", "ID");
        }
    }
}
