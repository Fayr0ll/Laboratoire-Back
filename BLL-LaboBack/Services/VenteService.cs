using BLL_LaboBack.Entities;
using BLL_LaboBack.Mapper;
using COMMON_LaboBack.Repositories;
using EF_LaboBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_LaboBack.Services
{
    public class VenteService : IVenteRepository<Vente>
    {
        private DataContext _context;

        public VenteService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Vente> Get()
        {
            try
            {
                return _context.Ventes.Select(v => v.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Vente>();
            }
        }

        public Vente Get(int id)
        {
            try
            {
                return _context.Ventes.First(v => v.VenteId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Vente();
            }
        }

        public bool Insert(Vente entity)
        {
            try
            {
                _context.Ventes.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Vente entity)
        {
            try
            {
                var vente = _context.Ventes.First(v => v.VenteId == id);
                vente.Prix = entity.Prix;
                vente.Quantitee = entity.Quantitee;
                vente.DateVente = entity.DateVente;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Ventes.Remove(_context.Ventes.First(v => v.VenteId == id));
            _context.SaveChanges();
        }
    }
}
