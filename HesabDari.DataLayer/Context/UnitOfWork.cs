using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HesabDari.DataLayer.GenericRepository;

namespace HesabDari.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        HesabDariEntitiesnew db = new HesabDariEntitiesnew();

        GenericRepository<Persons> _repositoryPerson;
       public GenericRepository<Persons> PersonRepository
        {
            get
            {
                if (_repositoryPerson == null)
                {
                    _repositoryPerson = new GenericRepository<Persons>(db);
                }
                return _repositoryPerson;
            }
        }

        GenericRepository<Accounting> _repositoryAccounting;
        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_repositoryAccounting == null)
                {
                    _repositoryAccounting = new GenericRepository<Accounting>(db);
                }
                return _repositoryAccounting;
            }
        }

        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {

                if(_loginRepository==null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
