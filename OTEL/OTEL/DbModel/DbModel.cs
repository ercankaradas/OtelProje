namespace OTEL.DbModel
{
    using OTEL.Classes.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        // Your context has been configured to use a 'DbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OTEL.DbModel.DbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbModel' 
        // connection string in the application configuration file.
        public DbModel()
            : base("name=DbModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Il> Iller { get; set; }
        public virtual DbSet<Ilce> Ilceler { get; set; }
        public virtual DbSet<Mahalle> Mahalleler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Oda> Odalar { get; set; }
        public virtual DbSet<Otel> Oteller { get; set; }
        public virtual DbSet<OtelOzellik> OtelOzellikleri { get; set; }
        public virtual DbSet<OtelResim> OtelResimleri { get; set; }
        public virtual DbSet<Ozellik> Ozellikler { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public virtual DbSet<Yildiz> Yildizlar { get; set; }
        public virtual DbSet<Yorum> Yorumlar { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}