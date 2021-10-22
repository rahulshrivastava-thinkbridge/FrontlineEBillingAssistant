using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Repository.Interface.Base
{
    public interface IRepository<T>
    {
        public Task<T> Create(T _object);

        public Task Update(T _object);

        public Task<IEnumerable<T>> GetAll();

        public Task<T> GetById(int Id);        

        public Task Delete(T _object);
    }
}
