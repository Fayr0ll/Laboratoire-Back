using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class GenreDeLivre : IGenreDeLivre
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
