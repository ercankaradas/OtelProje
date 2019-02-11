using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTEL.Classes.CrudFacede;
using OTEL.Classes.Entities;
using OTEL.DbModel;

namespace OTEL.Classes.Factory
{
    public class DbFactory
    {
        // DbModel
        private static volatile OTEL.DbModel.DbModel _db = null;
        public static OTEL.DbModel.DbModel DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new OTEL.DbModel.DbModel();
                }
                return _db;
            }
        }

        // Iller
        private static volatile OtelCrud<Il> _ilOtelCrud = null;
        public static OtelCrud<Il> IlOtelCrud
        {
            get
            {
                if (_ilOtelCrud == null)
                {
                    _ilOtelCrud = new OtelCrud<Il>(DB, DB.Iller);
                }
                return _ilOtelCrud;
            }
        }

        // Ilceler
        private static volatile OtelCrud<Ilce> _ilceOtelCrud = null;
        public static OtelCrud<Ilce> IlceOtelCrud
        {
            get
            {
                if (_ilceOtelCrud == null)
                {
                    _ilceOtelCrud = new OtelCrud<Ilce>(DB, DB.Ilceler);
                }
                return _ilceOtelCrud;
            }
        }

        //Mahalleler
        private static volatile OtelCrud<Mahalle> _mahalleOtelCrud = null;
        public static OtelCrud<Mahalle> MahalleOtelCrud
        {
            get
            {
                if (_mahalleOtelCrud == null)
                {
                    _mahalleOtelCrud = new OtelCrud<Mahalle>(DB, DB.Mahalleler);
                }
                return _mahalleOtelCrud;
            }
        }

        //Müsteriler
        private static volatile OtelCrud<Musteri> _musteriOtelCrud = null;
        public static OtelCrud<Musteri> MusteriOtelCrud
        {
            get
            {
                if (_musteriOtelCrud == null)
                {
                    _musteriOtelCrud = new OtelCrud<Musteri>(DB, DB.Musteriler);
                }
                return _musteriOtelCrud;
            }
        }

        //Oda
        private static volatile OtelCrud<Oda> _odaOtelCrud = null;
        public static OtelCrud<Oda> OdaOtelCrud
        {
            get
            {
                if (_odaOtelCrud == null)
                {
                    _odaOtelCrud = new OtelCrud<Oda>(DB, DB.Odalar);
                }
                return _odaOtelCrud;
            }
        }

        //Otel
        private static volatile OtelCrud<Otel> _otelOtelCrud = null;
        public static OtelCrud<Otel> OtelOtelCrud
        {
            get
            {
                if (_otelOtelCrud == null)
                {
                    _otelOtelCrud = new OtelCrud<Otel>(DB, DB.Oteller);
                }
                return _otelOtelCrud;
            }
        }

        //OtelOzellik
        private static volatile OtelCrud<OtelOzellik> _otelOzellikOtelCrud = null;
        public static OtelCrud<OtelOzellik> OtelOzellik
        {
            get
            {
                if (_otelOzellikOtelCrud == null)
                {
                    _otelOzellikOtelCrud = new OtelCrud<OtelOzellik>(DB, DB.OtelOzellikleri);
                }
                return _otelOzellikOtelCrud;
            }
        }

        //OtelResim
        private static volatile OtelCrud<OtelResim> _otelResimOtelCrud = null;
        public static OtelCrud<OtelResim> OtelResim
        {
            get
            {
                if (_otelResimOtelCrud == null)
                {
                    _otelResimOtelCrud = new OtelCrud<OtelResim>(DB, DB.OtelResimleri);
                }
                return _otelResimOtelCrud;
            }
        }

        //Ozellik
        private static volatile OtelCrud<Ozellik> _ozellikOtelCrud = null;
        public static OtelCrud<Ozellik> Ozellik
        {
            get
            {
                if (_ozellikOtelCrud == null)
                {
                    _ozellikOtelCrud = new OtelCrud<Ozellik>(DB, DB.Ozellikler);
                }
                return _ozellikOtelCrud;
            }
        }

        //Rezervasyon
        private static volatile OtelCrud<Rezervasyon> _rezervasyonOtelCrud = null;
        public static OtelCrud<Rezervasyon> Rezervasyon
        {
            get
            {
                if (_rezervasyonOtelCrud == null)
                {
                    _rezervasyonOtelCrud = new OtelCrud<Rezervasyon>(DB, DB.Rezervasyonlar);
                }
                return _rezervasyonOtelCrud;
            }
        }

        //Yildiz
        private static volatile OtelCrud<Yildiz> _yildizOtelCrud = null;
        public static OtelCrud<Yildiz> Yildiz
        {
            get
            {
                if (_yildizOtelCrud == null)
                {
                    _yildizOtelCrud = new OtelCrud<Yildiz>(DB, DB.Yildizlar);
                }
                return _yildizOtelCrud;
            }
        }

        //Yildiz
        private static volatile OtelCrud<Yorum> _yorumOtelCrud = null;
        public static OtelCrud<Yorum> Yorum
        {
            get
            {
                if (_yorumOtelCrud == null)
                {
                    _yorumOtelCrud = new OtelCrud<Yorum>(DB, DB.Yorumlar);
                }
                return _yorumOtelCrud;
            }
        }
    }
}
