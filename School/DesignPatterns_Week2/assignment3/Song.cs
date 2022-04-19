using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Song
    {
        string _Name;
        string _Artist;
        TimeSpan _Duration;

        public string Name { get { return _Name; } }
        public string Artist { get { return _Artist; } }
        public TimeSpan Duration { get { return _Duration; } }


        public Song(string name, string artist, TimeSpan duration)
        {
            this._Name = name;
            this._Artist = artist;
            this._Duration = duration;
        }
    }
}
