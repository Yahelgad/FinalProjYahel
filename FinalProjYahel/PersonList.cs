using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
 public class PersonList:List<Person>
    {
        public PersonList() { }
        public PersonList(IEnumerable<Person> list) { }
        public PersonList(IEnumerable<Base> list) : base(list.Cast<Person>().ToList()) { }
    }
}
