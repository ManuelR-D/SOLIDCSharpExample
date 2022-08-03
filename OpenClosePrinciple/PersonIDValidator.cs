using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.OpenClosePrinciple
{
    internal class PersonIDValidator : IValidator
    {
        private int id;

        public PersonIDValidator(int id)
        {
            this.id = id;
        }

        public bool isValid()
        {
            return id > 1_000_000 && id < 99_999_999;
        }
    }
}
