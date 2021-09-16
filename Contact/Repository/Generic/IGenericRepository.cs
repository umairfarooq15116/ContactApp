﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Repository.Generic
{
    #region Generic Interface
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetByID(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
    #endregion
}
