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
    public class BibliothequeService : IBibliothequeRepository<Bibliotheque>
    {
        private DataContext _context;

        public BibliothequeService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Bibliotheque> Get()
        {
            try
            {
                return _context.Bibliotheques.Select(b => b.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Bibliotheque>();
            }
        }

        public Bibliotheque Get(int id)
        {
            try
            {
                return _context.Bibliotheques.First(b => b.BibliothequeId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Bibliotheque();
            }
        }

        public bool Insert(Bibliotheque entity)
        {
            try
            {
                _context.Bibliotheques.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Bibliotheque entity)
        {
            try
            {
                var bibliotheque = _context.Bibliotheques.First(b => b.BibliothequeId == id);
                bibliotheque.Rue = entity.Rue;
                bibliotheque.Numero = entity.Numero;
                bibliotheque.Localite = entity.Localite;
                bibliotheque.CodePostal = entity.CodePostal;
                bibliotheque.Pays = entity.Pays;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Bibliotheques.Remove(_context.Bibliotheques.First(b => b.BibliothequeId == id));
            _context.SaveChanges();
        }
    }
}
