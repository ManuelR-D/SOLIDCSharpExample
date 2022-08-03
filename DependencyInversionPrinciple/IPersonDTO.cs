using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal interface IPersonDTO
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public char Gender { get; }
    }
}
