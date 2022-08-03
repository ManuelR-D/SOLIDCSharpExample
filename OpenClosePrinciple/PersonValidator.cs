using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.OpenClosePrinciple
{
    internal class PersonValidator
    {
        /**
         * If new validations are needed in the future, just create a new class that implements the IValidator interface
         * and add it to the list of validators. There is no need to modify code of the existing validators, neither to
         * add logic to this class.
         */
        public bool validate(int id, string name, char gender)
        {
            List<IValidator> validators = new List<IValidator>();
            validators.Add(new PersonIDValidator(id));
            validators.Add(new PersonGenderValidator(gender));
            foreach (IValidator validator in validators)
            {
                if (!validator.isValid())
                    return false;
            }
            return true;
        }
    }
}
