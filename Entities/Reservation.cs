using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ShowId { get; set; }
        public Show Show { get; set; }
    }
}
