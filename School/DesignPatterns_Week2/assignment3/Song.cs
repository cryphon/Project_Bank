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
        double _Duration;

        public string Name { get { return _Name; } }
        public string Artist { get { return _Artist; } }
        public double Duration { get { return _Duration; } }


        public Song(string name, string artist, double duration)
        {
            this._Name = name;
            this._Artist = artist;
            this._Duration = duration;
        }
    }
}
