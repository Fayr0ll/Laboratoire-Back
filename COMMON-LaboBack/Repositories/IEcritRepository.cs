using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON_LaboBack.Repositories
{
    public interface IEcritRepository<TEcrit> : ICRUDRepository<TEcrit, int> where TEcrit : IEcrit
    {
    }
}
