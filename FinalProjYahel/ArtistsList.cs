using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class ArtistsList:List<Artists>
    {
        public ArtistsList() { }
        public ArtistsList(IEnumerable<Artists> list) { }
        public ArtistsList(IEnumerable<Base> list):base(list.Cast<Artists>().ToList()) { }
    }
}
