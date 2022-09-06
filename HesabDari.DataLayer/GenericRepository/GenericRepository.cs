using HesabDari.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace HesabDari.DataLayer.GenericRepository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private HesabDariEntitiesnew _db;
        private DbSet<TEntity> _dbset;

        public GenericRepository(HesabDariEntitiesnew context)
        {
            _db = context;
            _dbset = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbset;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbset.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            _dbset.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }

        public virtual string GetNameById(int id)
        {
            return _db.Persons.Find(id).Name;
        }

        public virtual string GetFamilyById(int id)
        {
            return _db.Persons.Find(id).Family;
        }

        public virtual string GetByAccountId(int id)
        {
            return _db.Accounting.Find(id).PersonId.ToString();
        }

        public List<ListPersonsViewModel> GetPersonsName(string filter = "")
        {
            if (filter == "")
            {
                return _db.Persons.Select(c => new ListPersonsViewModel()
                {
                    Name = c.Name + " " + c.Family,
                    PersonId=c.PersonId
                }).ToList();
            }
            return _db.Persons.Where(c => c.Name.Contains(filter)).Select(c => new ListPersonsViewModel()
            {
                Name = c.Name + " " + c.Family,
                PersonId = c.PersonId
            }).ToList();
        }


    }
}
