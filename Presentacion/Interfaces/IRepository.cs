using System;
using System.Collections.Generic;
using System.Text;

namespace NatatorioCEF.Interfaces
{
    public interface IRepository
    {
        void Add(object obj);
        object GetById(int id);
        IEnumerable<object> GetAll();
        void Update(object obj);
        void Delete(int id);
    }
}
