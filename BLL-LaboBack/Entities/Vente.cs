using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class Vente : IVente
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
