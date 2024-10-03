using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class User
    {
        //Propriétés
        public int UserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
        public string MDP { get; set; }
        public string Salage { get; set; }

        //ForeignKey

        //Propriétés liens
        public List<Vente> Ventes { get; set; }
        public List<Location> Locations { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
