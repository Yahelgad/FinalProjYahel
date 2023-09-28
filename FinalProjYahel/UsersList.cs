using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class UsersList:List<Users>
    {
        public UsersList() { }
        public UsersList(IEnumerable<Users> list) { }
        public UsersList(IEnumerable<Base> list) : base(list.Cast<Users>().ToList()) { }
    }
}
