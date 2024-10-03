using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class GenreDeLivre
    {
        //Propriété

        //ForeignKey
        public int ISBN { get; set; }
        public int GenreId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Genre Genre { get; set; }
    }
}
