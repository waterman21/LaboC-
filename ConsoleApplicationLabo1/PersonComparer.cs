using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person pers1, Person pers2)
        {
            bool memePers = false;

            if (pers1.Name.Equals(pers2.Name) && pers1.Age == pers2.Age)
                memePers = true;
           
             return memePers;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode()^obj.Age;
        }
    }
}
