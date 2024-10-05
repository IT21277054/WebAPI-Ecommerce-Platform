﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAsync();
    Task<T> GetByIdAsync(int Id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
 
}
