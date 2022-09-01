using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.ViewModels
{
    public class ShowVM
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public float Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Price { get; set; }

        public int DirectorId { get; set; }
    }
}
