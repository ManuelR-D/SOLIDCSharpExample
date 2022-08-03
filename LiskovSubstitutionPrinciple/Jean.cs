using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.LiskovSubstitutionPrinciple
{
    internal class Jean : Clothes
    {
        private double cost;
        public Jean(string name, string description, int id, string type, double cost): base(name, description, id, type)
        {
            this.cost = cost;
        }
        public override double getCost()
        {
            return cost * 1.5;
        }
    }
}
