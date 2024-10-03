using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class Livre : ILivre
    {
        //Propriétés
        public int ISBN { get; set; }
        public string Titre { get; set; }
        public string Edition { get; set; }
        public int AnneeEdition { get; set; }
        public double Prix { get; set; }
        public bool Prime { get; set; }

        //ForeignKey

        //Propriétés liens
        public List<BibliothequeLivre> BibliothequesLivres { get; set; }
        public List<Ecrit> Ecrits { get; set; }
        public List<GenreDeLivre> GenresDesLivres { get; set; }
        public List<VenteDeLivre> VentesDesLivres { get; set; }
        public List<LocationDeLivre> LocationsDesLivres { get; set; }

    }
}
