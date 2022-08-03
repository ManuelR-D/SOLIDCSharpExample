using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.DependencyInversionPrinciple
{
    internal class Person : IPersonDTO
    {
        private int personId;
        private string name;
        private int age;
        private char gender;

        public Person(int? personId, string? name, int? age, char? gender)
        {
            this.personId = (int)personId;
            this.name = name;
            this.age = (int)age;
            this.gender = (char)gender;
        }

        public int Id { get { return this.personId; } }

        public string Name { get { return this.name; } }

        public int Age { get { return this.age; } }

        public char Gender { get { return this.gender; } }
    }
}
