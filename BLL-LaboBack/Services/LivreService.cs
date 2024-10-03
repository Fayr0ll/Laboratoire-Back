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
    public class LivreService : ILivreRepository<Livre>
    {
        private DataContext _context;

        public LivreService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Livre> Get()
        {
            try
            {
                return _context.Livres.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Livre>();
            }
        }

        public Livre Get(int id)
        {
            try
            {
                return _context.Livres.First(l => l.ISBN == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Livre();
            }
        }

        public bool Insert(Livre entity)
        {
            try
            {
                _context.Livres.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Livre entity)
        {
            try
            {
                var livre = _context.Livres.First(l => l.ISBN == id);
                livre.Titre = entity.Titre;
                livre.Edition = entity.Edition;
                livre.AnneeEdition = entity.AnneeEdition;
                livre.Prix = entity.Prix;
                livre.Prime = entity.Prime;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Livres.Remove(_context.Livres.First(l => l.ISBN == id));
            _context.SaveChanges();
        }
    }
}
