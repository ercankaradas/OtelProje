namespace OTEL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String(maxLength: 40));
            AlterColumn("dbo.Ilceler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ilceler", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String(maxLength: 40));
            AlterColumn("dbo.Mahalleler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Mahalleler", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Iller", "IlAdi", c => c.String(maxLength: 20));
            AlterColumn("dbo.Iller", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Iller", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Musteriler", "Adi", c => c.String(maxLength: 20));
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String(maxLength: 20));
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "Tel", c => c.String(maxLength: 11));
            AlterColumn("dbo.Musteriler", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Musteriler", "TCKN", c => c.String(maxLength: 11));
            AlterColumn("dbo.Musteriler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Musteriler", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Odalar", "OdaNo", c => c.String(maxLength: 10));
            AlterColumn("dbo.Odalar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Odalar", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "Adi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String(maxLength: 250));
            AlterColumn("dbo.Oteller", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Oteller", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yildizlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yildizlar", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String(maxLength: 50));
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String(maxLength: 250));
            AlterColumn("dbo.Yorumlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Yorumlar", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.OtelOzellikleri", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Ozellikler", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Ozellikler", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.OtelResimleri", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.OtelResimleri", "GuncelleyenKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisiID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Rezervasyonlar", "GuncelleyenKisiID", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervasyonlar", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Rezervasyonlar", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.OtelResimleri", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.OtelResimleri", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Ozellikler", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Ozellikler", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Ozellikler", "OzellikAdi", c => c.String());
            AlterColumn("dbo.OtelOzellikleri", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.OtelOzellikleri", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Yorumlar", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Yorumlar", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumIcerigi", c => c.String());
            AlterColumn("dbo.Yorumlar", "YorumBasligi", c => c.String());
            AlterColumn("dbo.Yildizlar", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Yildizlar", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Oteller", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Oteller", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Oteller", "Aciklama", c => c.String());
            AlterColumn("dbo.Oteller", "ResmiAdi", c => c.String());
            AlterColumn("dbo.Oteller", "VergiNo", c => c.String());
            AlterColumn("dbo.Oteller", "Adi", c => c.String());
            AlterColumn("dbo.Odalar", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Odalar", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Odalar", "OdaNo", c => c.String());
            AlterColumn("dbo.Musteriler", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Musteriler", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Musteriler", "TCKN", c => c.String());
            AlterColumn("dbo.Musteriler", "Email", c => c.String());
            AlterColumn("dbo.Musteriler", "Tel", c => c.String());
            AlterColumn("dbo.Musteriler", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Musteriler", "Sifre", c => c.String());
            AlterColumn("dbo.Musteriler", "Soyadi", c => c.String());
            AlterColumn("dbo.Musteriler", "Adi", c => c.String());
            AlterColumn("dbo.Iller", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Iller", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Iller", "IlAdi", c => c.String());
            AlterColumn("dbo.Mahalleler", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Mahalleler", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Mahalleler", "MahalleAdi", c => c.String());
            AlterColumn("dbo.Ilceler", "GuncelleyenKisiID", c => c.String());
            AlterColumn("dbo.Ilceler", "OlusturanKisiID", c => c.String());
            AlterColumn("dbo.Ilceler", "IlceAdi", c => c.String());
        }
    }
}
