using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.SingleResponsabilityPrinciple
{
    internal class PersonIDValidator
    {
        private int id;

        public PersonIDValidator(int id)
        {
            this.id = id;
        }

        internal bool isValid()
        {
            return id > 1_000_000 && id < 99_999_999;
        }
    }
}
