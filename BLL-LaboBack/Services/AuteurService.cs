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
    public class AuteurService : IAuteurRepository<Auteur>
    {
        private DataContext _context;

        public AuteurService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Auteur> Get()
        {
            try
            {
                return _context.Auteurs.Select(a => a.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Auteur>();
            }
        }

        public Auteur Get(int id)
        {
            try
            {
                return _context.Auteurs.First(a => a.AuteurId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Auteur();
            }
        }

        public bool Insert(Auteur entity)
        {
            try
            {
                _context.Auteurs.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Auteur entity)
        {
            try
            {
                var auteur = _context.Auteurs.First(a => a.AuteurId == id);
                auteur.Nom = entity.Nom;
                auteur.Prenom = entity.Prenom;
                auteur.NbrOuvrage = entity.NbrOuvrage;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Auteurs.Remove(_context.Auteurs.First(a => a.AuteurId == id));
            _context.SaveChanges();
        }
    }
}
