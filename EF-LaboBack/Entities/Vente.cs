using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class Vente
    {
        //Propriétés
        public int VenteId { get; set; }
        public double Prix { get; set; }
        public int Quantitee { get; set; }
        public DateTime DateVente { get; set; }

        //ForeignKey
        public int UserId { get; set; }

        //Propriétés liens
        public User User { get; set; }
        public List<VenteDeLivre> VentesDesLivres { get; set; }
    }
}
