using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.InterfaceSegregationPrinciple
{
    internal interface IClothes : ITaxable
    {
        public string Name { get; }
        public string Description { get; }
        public int Id { get; }
        public string Type { get; }

        public double getCost();
    }
}
