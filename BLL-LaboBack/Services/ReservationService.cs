using BLL_LaboBack.Entities;
using BLL_LaboBack.Mapper;
using COMMON_LaboBack.Entities;
using COMMON_LaboBack.Repositories;
using EF_LaboBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LaboBack.Services
{
    public class ReservationService : IReservationRepository<Reservation>
    {
        private DataContext _context;

        public ReservationService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Reservation> Get()
        {
            try
            {
                return _context.Reservations.Select(r => r.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Reservation>();
            }
        }

        public Reservation Get(int id)
        {
            try
            {
                return _context.Reservations.First(r => r.ReservationId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Reservation();
            }
        }

        public bool Insert(Reservation entity)
        {
            try
            {
                _context.Reservations.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Reservation entity)
        {
            try
            {
                var reservation = _context.Reservations.First(r => r.ReservationId == id);
                reservation.DateReservation = entity.DateReservation;
                reservation.Acompte = entity.Acompte;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Reservations.Remove(_context.Reservations.First(r => r.ReservationId == id));
            _context.SaveChanges();
        }
    }
}
