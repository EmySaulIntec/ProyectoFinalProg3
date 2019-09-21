using DatabaseProject.Contexts;
using DatabaseProject.Models;
using System;
using System.Collections.Generic;

namespace DatabaseProject.Repositories
{
    public class UnitOfWork
    {
        private readonly CashDbContext context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(CashDbContext context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new CashDbContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public BaseRepository<T> Repository<T>() where T : BaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(BaseRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (BaseRepository<T>)repositories[type];
        }
    }
}
