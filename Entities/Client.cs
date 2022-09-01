using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Email { get; set; }
        public DateTime BirthDate { get; set; }

        //
        //Navigation Properties
        public virtual Card Card { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        /*
        client_id number(6) primary key,
        lastname varchar2(30) not null,
        firstname varchar2(30) not null,
        email varchar2(25) not null,
        birth_date date,
        */
    }
}
