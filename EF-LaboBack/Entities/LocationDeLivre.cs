using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class LocationDeLivre
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
