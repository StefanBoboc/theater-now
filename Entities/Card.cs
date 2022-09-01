using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Brand { get; set; }

        //
        //Navigation Properties
        public int ClientId { get; set; }
        public virtual  Client Client { get; set; }


        /*
        card_id number(6) primary key,
        expiration_month number(2) not null,
        expiration_year number(2) not null,
        brand varchar2(15) not null,
        client_id number(6) unique
        */
    }
}
