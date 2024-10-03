using System;
using System.Collections.Generic;
using System.Text;
using COMMON_LaboBack.Entities;

namespace COMMON_LaboBack.Repositories
{
    public interface IBibliothequeLivreRepository<TBibliothequeLivre> : ICRUDRepository<TBibliothequeLivre, int> where TBibliothequeLivre : IBibliothequeLivre
    {
    }
}
