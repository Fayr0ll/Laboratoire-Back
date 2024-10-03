using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class Location
    {
        //Propriétés
        public int LocationId { get; set; }
        public DateTime DebutLocation { get; set; }
        public DateTime? RetourLocation { get; set; }
        public double? Prix { get; set; }

        //ForeignKey
        public int UserId { get; set; }

        //Propriétés liens
        public User User { get; set; }
        public List<LocationDeLivre> LocationsDesLivres { get; set; }
    }
}
