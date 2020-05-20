﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces.Generics
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> getEntityById(int Id);
        Task<List<T>> List();
    }
}
