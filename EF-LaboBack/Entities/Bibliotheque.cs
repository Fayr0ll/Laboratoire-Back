using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class Bibliotheque
    {
        //Propriétés
        public int BibliothequeId { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Localite { get; set; }
        public string Pays { get; set; }

        //ForeignKey

        //Propriété lien
        public List<BibliothequeLivre> BibliothequesLivres { get; set; }
    }
}
