using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_LaboBack.Entities
{
    public class Genre
    {
        //Propriété
        public int GenreId { get; set; }
        public string NomGenre { get; set; }

        //ForeignKey

        //Propriété lien
        public List<GenreDeLivre> GenresDesLivres { get; set; }
    }
}
