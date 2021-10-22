using FrontlineEBillingAssistant.Core.Data;
using FrontlineEBillingAssistant.Repository.Interface.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EBillingContext _ebillingContext;

        public Repository(EBillingContext ebillingContext)
        {
            _ebillingContext = ebillingContext;
        }

        public async Task<T> Create(T entity)
        {
            await _ebillingContext.Set<T>().AddAsync(entity);
            await _ebillingContext.SaveChangesAsync();
            return entity;
        }
        public async Task Delete(T entity)
        {
            _ebillingContext.Set<T>().Remove(entity);
            await _ebillingContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _ebillingContext.Set<T>().Take(1000).ToListAsync();
        }
        public async Task<T> GetById(int id)
        {
            return await _ebillingContext.Set<T>().FindAsync(id);
        }
        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
