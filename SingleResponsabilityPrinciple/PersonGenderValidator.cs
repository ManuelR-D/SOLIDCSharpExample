using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.SingleResponsabilityPrinciple
{
    internal class PersonGenderValidator
    {
        private char gender;
        private static HashSet<Char> acceptedGenders = new HashSet<Char>() { 'M','F','X' };
        public PersonGenderValidator(char gender)
        {
            this.gender = gender;
        }

        internal bool isValid()
        {
            return acceptedGenders.Contains(gender);
        }
    }
}
