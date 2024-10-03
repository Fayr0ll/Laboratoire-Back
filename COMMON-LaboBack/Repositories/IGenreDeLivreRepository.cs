using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON_LaboBack.Repositories
{
    public interface IGenreDeLivreRepository<TGenreDeLivre> : ICRUDRepository<TGenreDeLivre, int> where TGenreDeLivre : IGenreDeLivre
    {
    }
}
