using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADAssignment
{
    public class Genre
    {
        public Genre() { }
        public Genre(string genreType)
        {
            this.GenreType = genreType;
        }

        public string GenreType { get; set; }
    }
}
