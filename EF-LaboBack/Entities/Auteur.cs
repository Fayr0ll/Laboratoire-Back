using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class Auteur
    {
        //Propriétés
        public int AuteurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NbrOuvrage { get; set; }

        //ForeignKey

        //Propriété lien
        public List<Ecrit> Ecrits { get; set; }
    }
}
