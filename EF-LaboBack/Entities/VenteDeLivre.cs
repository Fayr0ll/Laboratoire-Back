using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class VenteDeLivre
    {
        //Propriété

        //ForeignKey
        public int ISBN { get; set; }
        public int VenteId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Vente Vente { get; set; }
    }
}
