using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjYahel
{
    public class Songs:Base
    {
        private string nameSong;
        private Jenre jenre;
        private Artists artistName;
        private DateOnly creationDate;
        private TimeOnly time;
        private string link;

        public string NameSong { get => nameSong; set => nameSong = value; }
        public Jenre Jenre { get => jenre; set => jenre = value; }
        public Artists ArtistName { get => artistName; set => artistName = value; }
        public DateOnly CreationDate { get => creationDate; set => creationDate = value; }
        public TimeOnly Time { get => time; set => time = value; }
        public string Link { get => link; set => link = value; }
    }
}
