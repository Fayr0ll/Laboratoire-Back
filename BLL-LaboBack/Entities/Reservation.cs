using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON_LaboBack.Entities;

namespace BLL_LaboBack.Entities
{
    public class Reservation : IReservation
    {
        //Propriétés
        public int ReservationId { get; set; }
        public DateTime DateReservation { get; set; }
        public double Acompte { get; set; }

        //ForeignKey
        public int UserId { get; set; }

        //Propriétés liens
        public User User { get; set; }
        public List<ReservationDeLivre> ReservationsDesLivres { get; set; }
    }
}
