using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal interface ICrud<T>
    {
        T getById(int id);
        T save(T entity);
        bool update(T entity);
        bool deleteById(int id);
    }
}
