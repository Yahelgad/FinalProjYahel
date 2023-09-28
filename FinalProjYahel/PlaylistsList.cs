using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class PlaylistsList:List<Playlists>
    {
        public PlaylistsList() { }
        public PlaylistsList(IEnumerable<Playlists> list) { }
        public PlaylistsList(IEnumerable<Base> list) : base(list.Cast<Playlists>().ToList()) { }
    }
}
