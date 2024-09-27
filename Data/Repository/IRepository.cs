﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string id);
        Task<List<T>> GetRangeAsync(List<string> ids); 
        Task<List<T>> GetAllAsync();
    }
}
