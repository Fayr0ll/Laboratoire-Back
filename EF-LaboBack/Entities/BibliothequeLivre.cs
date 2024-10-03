using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class BibliothequeLivre
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
