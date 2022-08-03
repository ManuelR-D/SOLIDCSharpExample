using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.InterfaceSegregationPrinciple
{
    internal class TShirt : Clothes, ITaxable
    {
        private double cost;
        private const double TAX = 1.21;
        public TShirt(string name, string description, int id, string type, double cost): base(name, description, id, type)
        {
            this.cost = cost;
        }

        public override double getAppliableTax()
        {
            return TAX;
        }

        public override double getCost()
        {
            return cost * 2;
        }
    }
}
