using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class SongsList:List<Songs>
    {
        public SongsList() { }
        public SongsList(IEnumerable<Songs> list) { }
        public SongsList(IEnumerable<Base> list) : base(list.Cast<Songs>().ToList()) { }
    }
}
