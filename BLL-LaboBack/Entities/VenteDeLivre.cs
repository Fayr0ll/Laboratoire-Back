using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class VenteDeLivre : IVenteDeLivre
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
