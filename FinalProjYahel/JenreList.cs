using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
   public class JenreList:List<Jenre>
    {
        public JenreList() { }
        public JenreList(IEnumerable<Jenre> list) { }
        public JenreList(IEnumerable<Base> list) : base(list.Cast<Jenre>().ToList()) { }
    }
}
