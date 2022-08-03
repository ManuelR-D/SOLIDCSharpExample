using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal abstract class CrudAPI<T> : ICrud<T>
    {
        protected ICrud<T>? entityDao;
        public abstract bool deleteById(int id);

        public abstract T getById(int id);

        public abstract T save(T entity);

        public abstract bool update(T entity);

        public CrudAPI(ICrud<T> entityDao)
        {
            this.entityDao = entityDao;
        }
    }
}
