using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCSharpExample.OpenClosePrinciple
{
    internal class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }

        public Person(int id, string name, char gender)
        {
            PersonValidator validator = new PersonValidator();
            if (!validator.validate(id, name, gender))
                throw new Exception($"Invalid parameters for a Person instance: {id}, {name}, {gender}");
            Id = id;
            Name = name;
            Gender = gender;
        }
    }
}
