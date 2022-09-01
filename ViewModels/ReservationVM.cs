using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.ViewModels
{
    public class ReservationVM
    {
        public DateTime BookingDate { get; set; }
        public int ClientId { get; set; }
        public int ShowId { get; set; }
    }
}
