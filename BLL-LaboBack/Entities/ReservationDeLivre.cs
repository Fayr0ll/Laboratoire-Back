using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LaboBack.Entities;

namespace BLL_LaboBack.Entities
{
    public class ReservationDeLivre : IReservationDeLivre
    {
        //Propriété

        //ForeignKey
        public int ISBN { get; set; }
        public int ReservationId { get; set; }

        //Propriétés liens
        public Livre Livre { get; set; }
        public Reservation Reservation { get; set; }
    }
}
