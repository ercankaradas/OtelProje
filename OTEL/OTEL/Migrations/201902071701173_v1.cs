namespace OTEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilceler",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Il_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Iller", t => t.Il_ID)
                .Index(t => t.Il_ID);
            
            CreateTable(
                "dbo.Mahalleler",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Ilce_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ilceler", t => t.Ilce_ID)
                .Index(t => t.Ilce_ID);
            
            CreateTable(
                "dbo.Iller",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IlAdi = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Sifre = c.String(),
                        KullaniciAdi = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                        TCKN = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Odalar",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OdaNo = c.String(),
                        OdaTipi = c.Int(nullable: false),
                        BosMu = c.Boolean(nullable: false),
                        Ucret = c.Double(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Oteller_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oteller", t => t.Oteller_ID)
                .Index(t => t.Oteller_ID);
            
            CreateTable(
                "dbo.Oteller",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        VergiNo = c.String(),
                        ResmiAdi = c.String(),
                        Aciklama = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Adres_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Iller", t => t.Adres_ID)
                .Index(t => t.Adres_ID);
            
            CreateTable(
                "dbo.Yildizlar",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                        Yorum_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oteller", t => t.Otel_ID)
                .ForeignKey("dbo.Yorumlar", t => t.Yorum_ID)
                .Index(t => t.Otel_ID)
                .Index(t => t.Yorum_ID);
            
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        YorumBasligi = c.String(),
                        YorumIcerigi = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Musteriler_ID = c.String(maxLength: 128),
                        Otel_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteriler", t => t.Musteriler_ID)
                .ForeignKey("dbo.Oteller", t => t.Otel_ID)
                .Index(t => t.Musteriler_ID)
                .Index(t => t.Otel_ID);
            
            CreateTable(
                "dbo.OtelOzellikleri",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                        Ozellik_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oteller", t => t.Otel_ID)
                .ForeignKey("dbo.Ozellikler", t => t.Ozellik_ID)
                .Index(t => t.Otel_ID)
                .Index(t => t.Ozellik_ID);
            
            CreateTable(
                "dbo.Ozellikler",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OtelResimleri",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Resim = c.Byte(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        Otel_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oteller", t => t.Otel_ID)
                .Index(t => t.Otel_ID);
            
            CreateTable(
                "dbo.Rezervasyonlar",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OnaylandıMı = c.Boolean(nullable: false),
                        KisiSayi = c.Short(nullable: false),
                        ChenkIn = c.DateTime(nullable: false),
                        ChenkOut = c.DateTime(nullable: false),
                        odemeZamani = c.Int(nullable: false),
                        OlusturulmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisiID = c.String(),
                        GuncellenmeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisiID = c.String(),
                        musteri_ID = c.String(maxLength: 128),
                        oda_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musteriler", t => t.musteri_ID)
                .ForeignKey("dbo.Odalar", t => t.oda_ID)
                .Index(t => t.musteri_ID)
                .Index(t => t.oda_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyonlar", "oda_ID", "dbo.Odalar");
            DropForeignKey("dbo.Rezervasyonlar", "musteri_ID", "dbo.Musteriler");
            DropForeignKey("dbo.OtelResimleri", "Otel_ID", "dbo.Oteller");
            DropForeignKey("dbo.OtelOzellikleri", "Ozellik_ID", "dbo.Ozellikler");
            DropForeignKey("dbo.OtelOzellikleri", "Otel_ID", "dbo.Oteller");
            DropForeignKey("dbo.Odalar", "Oteller_ID", "dbo.Oteller");
            DropForeignKey("dbo.Yorumlar", "Otel_ID", "dbo.Oteller");
            DropForeignKey("dbo.Yildizlar", "Yorum_ID", "dbo.Yorumlar");
            DropForeignKey("dbo.Yorumlar", "Musteriler_ID", "dbo.Musteriler");
            DropForeignKey("dbo.Yildizlar", "Otel_ID", "dbo.Oteller");
            DropForeignKey("dbo.Oteller", "Adres_ID", "dbo.Iller");
            DropForeignKey("dbo.Ilceler", "Il_ID", "dbo.Iller");
            DropForeignKey("dbo.Mahalleler", "Ilce_ID", "dbo.Ilceler");
            DropIndex("dbo.Rezervasyonlar", new[] { "oda_ID" });
            DropIndex("dbo.Rezervasyonlar", new[] { "musteri_ID" });
            DropIndex("dbo.OtelResimleri", new[] { "Otel_ID" });
            DropIndex("dbo.OtelOzellikleri", new[] { "Ozellik_ID" });
            DropIndex("dbo.OtelOzellikleri", new[] { "Otel_ID" });
            DropIndex("dbo.Yorumlar", new[] { "Otel_ID" });
            DropIndex("dbo.Yorumlar", new[] { "Musteriler_ID" });
            DropIndex("dbo.Yildizlar", new[] { "Yorum_ID" });
            DropIndex("dbo.Yildizlar", new[] { "Otel_ID" });
            DropIndex("dbo.Oteller", new[] { "Adres_ID" });
            DropIndex("dbo.Odalar", new[] { "Oteller_ID" });
            DropIndex("dbo.Mahalleler", new[] { "Ilce_ID" });
            DropIndex("dbo.Ilceler", new[] { "Il_ID" });
            DropTable("dbo.Rezervasyonlar");
            DropTable("dbo.OtelResimleri");
            DropTable("dbo.Ozellikler");
            DropTable("dbo.OtelOzellikleri");
            DropTable("dbo.Yorumlar");
            DropTable("dbo.Yildizlar");
            DropTable("dbo.Oteller");
            DropTable("dbo.Odalar");
            DropTable("dbo.Musteriler");
            DropTable("dbo.Iller");
            DropTable("dbo.Mahalleler");
            DropTable("dbo.Ilceler");
        }
    }
}
