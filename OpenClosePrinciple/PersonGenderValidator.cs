using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.OpenClosePrinciple
{
    internal class PersonGenderValidator : IValidator
    {
        private char gender;
        private static HashSet<Char> acceptedGenders = new HashSet<Char>() { 'M','F','X' };
        public PersonGenderValidator(char gender)
        {
            this.gender = gender;
        }

        public bool isValid()
        {
            return acceptedGenders.Contains(gender);
        }
    }
}
