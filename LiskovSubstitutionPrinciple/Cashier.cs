using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.LiskovSubstitutionPrinciple
{
    internal class Cashier
    {
        const double VAT = 1.21; 
        /**
         * This class can get the total cost of any Clothe (TShirts and/or Jeans) since they can be treated as equalst thanks to LSP.
         */
        public double getTotalCost(List<Clothes> clothes)
        {
            double totalCost = 0;
            foreach(Clothes clothesItem in clothes)
            {
                totalCost += clothesItem.getCost();
            }
            return totalCost * VAT;
        }
    }
}
