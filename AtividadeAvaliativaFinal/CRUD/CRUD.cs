using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.CRUD
{
    interface CRUD<T>
    {
        public bool Create(T value);
        public List<T> Read();
        public T ReadById(int id);
    
        public void Update(T value);
        public void Delete(T value);
    }
}
