using OTEL.Classes.Crud;
using OTEL.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.CrudFacede
{
    public class OtelCrud<T> : IOtelRep<T> where T : DbObject
    {
        private DbContext _database;
        private DbSet<T> _table;

        public OtelCrud(DbContext database, DbSet<T> table)
        {
            _database = database;
            _table = table;
        }

        public List<T> Listeleme {
            get
            {
                bool isSoftDelete = typeof(T).IsAssignableFrom(typeof(DbObjectSD));
                if (isSoftDelete==false)
                {
                    return _table.ToList();
                }
                else
                {
                    return _table.Where(x => (x as DbObjectSD).GecerliMi == true).ToList();
                }                
            }
        }

        public bool Insert(T Entity)
        {
            try
            {
                _table.Add(Entity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Delete(T Entity)
        {
            try
            {
                bool isSoftDelete = typeof(T).IsAssignableFrom(typeof(DbObjectSD));
                if (isSoftDelete==false)
                {
                    _table.Remove(Entity);                    
                }
                else
                {
                    (Entity as DbObjectSD).GecerliMi = false;
                    _database.Entry(Entity).CurrentValues.SetValues(Entity);
                }
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string ID)
        {
            try
            {
                var Entity = Find(ID);
                bool isSoftDelete = typeof(T).IsAssignableFrom(typeof(DbObjectSD));
                if (isSoftDelete==false)
                {
                    _table.Remove(Entity);
                }
                else
                {
                    (Entity as DbObjectSD).GecerliMi = false;
                    _database.Entry(Entity).CurrentValues.SetValues(Entity);
                }
                
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(string ID)
        {
            var Entity = _table.FirstOrDefault(x => x.ID == ID);
            if (Entity!= null)
            {
                return Entity;
            }
            else
            {
                return null;
            }
        }

        public bool Update(T Entity)
        {
            try
            {
                _database.Entry(Entity).CurrentValues.SetValues(Entity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(string ID)
        {
            try
            {
                var Entity = Find(ID);
                _database.Entry(Entity).CurrentValues.SetValues(Entity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
