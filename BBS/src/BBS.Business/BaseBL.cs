using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBS.Domain;

namespace BBS.Business
{
    public abstract class BaseBL<T> : IBaseBL<T>, IDisposable
        where T : BaseEntity
    {
        readonly BbsContext _ctx;
        readonly IDbSet<T> _dbSet;

        private Type CurrentType { get; set; }

        protected BaseBL(BbsContext context)
        {
            _ctx = context;
            _dbSet = context.Set<T>();
            CurrentType = typeof(T);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T Find(int id)
        {
            return _dbSet.FirstOrDefault(u => u.Id == id);
        }

        public T Create(T obj)
        {
            try
            {
                _dbSet.Add(obj);

                if (_ctx.SaveChanges() > 0)
                {
                    return obj;
                }

                throw new ArgumentException("Error while saving data to db");
            }
            catch (Exception e)
            {
                // log
                Console.WriteLine(e);
                throw;
            }
        }

        public T Update(T obj)
        {
            try
            {
                var entity = _dbSet.FirstOrDefault(x => x.Id == obj.Id);

                if (entity == null)
                {
                    // move text to resources
                    throw new ArgumentNullException(nameof(obj), "entity couldn't find for updating");
                }

                _dbSet.AddOrUpdate(obj);

                if (_ctx.SaveChanges() > 0)
                {
                    return obj;
                }

                throw new ArgumentException("Error while updating data");

            }
            catch (Exception e)
            {
                // log
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _dbSet.SingleOrDefault(x => x.Id == id);

                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "user couldn't find for deleting");
                }

                _ctx.Set(CurrentType).Attach(entity);
                _ctx.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;

                _dbSet.Remove(entity);

                if (_ctx.SaveChanges() > 0)
                {
                    return true;
                }

                throw new ArgumentException("Error while deleting data");
            }
            catch (Exception e)
            {
                // log
                Console.WriteLine(e);
                throw;
            }

        }

        public void Dispose()
        {
            // _ctx?.Dispose(); -> short way
            if (_ctx != null)
            {
                _ctx.Dispose();
            }
        }
    }
}
