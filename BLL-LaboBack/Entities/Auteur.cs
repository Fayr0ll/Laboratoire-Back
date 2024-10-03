using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class Auteur : IAuteur
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
