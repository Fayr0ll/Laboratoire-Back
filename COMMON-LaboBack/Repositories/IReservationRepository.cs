using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON_LaboBack.Repositories
{
    public interface IReservationRepository<TReservation> : ICRUDRepository<TReservation, int> where TReservation : IReservation
    {
    }
}
