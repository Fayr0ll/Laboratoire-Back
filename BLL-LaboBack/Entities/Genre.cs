using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_LaboBack.Entities
{
    public class Genre : IGenre
    {
        //Propriété
        public int GenreId { get; set; }
        public string NomGenre { get; set; }

        //ForeignKey

        //Propriété lien
        public List<GenreDeLivre> GenresDesLivres { get; set; }
    }
}
