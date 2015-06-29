using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMedia.Models
{
    class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }
        public int Runtime { get; set; }
        public int MPAARatingID { get; set; }
        public int posterID { get; set; }


        public virtual MPAARating MPAARating { get; set; }
        public virtual Image Poster { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Image> Backdrops { get; set; }
    }
}
