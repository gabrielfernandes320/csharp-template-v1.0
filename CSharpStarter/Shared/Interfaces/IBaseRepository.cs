﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpStarter.Shared.Infra.Ef.Repositories
{
    public interface IBaseRepository<T>
    {
        public Task<ICollection<T>> FindAll();
        public Task<T> FindById(int id);
        public Task<T> Create(T entity);
        public Task<T> Update(int id, T entity);
        public Task Delete(int id);
    }
}
