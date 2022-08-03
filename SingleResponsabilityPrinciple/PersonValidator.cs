using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.SingleResponsabilityPrinciple
{
    internal class PersonValidator
    {
        /**
         * This validator knows the existence of all other validators, and has the single responsability to call 
         * all of them, but doesnt know the inner workings of how to validate each field.
         */
        public bool validate(int id, string name, char gender)
        {
            PersonIDValidator idValidator = new PersonIDValidator(id);
            if (!idValidator.isValid())
            {
                return false;
            }
            PersonGenderValidator genderValidator = new PersonGenderValidator(gender);
            if (!genderValidator.isValid())
            {
                return false;
            }
            return true;
        }
    }
}
