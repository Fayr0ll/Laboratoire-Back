using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class BibliothequeLivre : IBibliothequeLivre
    {
        //Propriétés
        public int StockDisponible { get; set; }

        //ForeignKey
        public int ISBN { get; set; }
        public int BibliothequeId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Bibliotheque Bibliotheque { get; set; }
    }
}
