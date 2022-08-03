using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal interface ICrudDAO<T> : ICrud<T>
    {
        void connect();
        void disconnect();
    }
}
