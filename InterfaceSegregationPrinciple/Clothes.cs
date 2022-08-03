using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.InterfaceSegregationPrinciple
{
    internal abstract class Clothes : IClothes
    {
        public string Name { get; }
        public string Description { get; }
        public int Id { get; }
        public string Type { get; }

        public abstract double getCost();

        public abstract double getAppliableTax();

        public Clothes(string name, string description, int id, string type)
        {
            Name = name;
            Description = description;
            Id = id;
            Type = type;
        }
    }
}
