using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON_LaboBack.Repositories
{
    public interface IReservationDeLivreRepository<TReservationDeLivre> : ICRUDRepository<TReservationDeLivre, int> where TReservationDeLivre : IReservationDeLivre
    {
    }
}
