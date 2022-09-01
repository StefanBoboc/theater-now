using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //
        //Navigation Properties
        public virtual ICollection<Show> Shows { get; set; }
    }
}
