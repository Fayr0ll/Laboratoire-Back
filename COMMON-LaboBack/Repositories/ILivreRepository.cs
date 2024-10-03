using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON_LaboBack.Repositories
{
    public interface ILivreRepository<TLivre> : ICRUDRepository<TLivre, int> where TLivre : ILivre
    {
    }
}
