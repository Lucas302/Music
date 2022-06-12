using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Album
    {
        string id;
        string name;
        int year;
        Artist band;
        List<Track> trackList;

        public Album(string id, string name, int year, List<Track> trackList)
        {
            this.id = id;
            this.name = name;
            this.trackList = trackList;
        }
    }
}
