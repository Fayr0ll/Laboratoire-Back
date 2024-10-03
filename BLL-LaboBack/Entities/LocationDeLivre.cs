using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class LocationDeLivre : ILocationDeLivre
    {
        //Propriété

        //ForeignKey
        public int ISBN { get; set; }
        public int LocationId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Location Location { get; set; }
    }
}
