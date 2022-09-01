using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class Show
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public float Rating { get; set; }
        public int ReleaseYear { get; set; }
        public int Price { get; set; }

        //
        //Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
    }
}
