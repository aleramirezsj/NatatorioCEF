using System;
using System.Collections.Generic;
using System.Text;

namespace NatatorioCEF.Interfaces
{
    internal interface IRepository
    {
        void Add(object obj);
        object GetById(int id);
        IEnumerable<object> GetAll();
        void Update(object obj);
        void Delete(int obj);
        //void Dispose();
    }
}
