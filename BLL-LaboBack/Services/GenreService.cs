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
    public class GenreService : IGenreRepository<Genre>
    {
        private DataContext _context;

        public GenreService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> Get()
        {
            try
            {
                return _context.Genres.Select(g => g.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Genre>();
            }
        }

        public Genre Get(int id)
        {
            try
            {
                return _context.Genres.First(g => g.GenreId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Genre();
            }
        }

        public bool Insert(Genre entity)
        {
            try
            {
                _context.Genres.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Genre entity)
        {
            try
            {
                var genre = _context.Genres.First(g => g.GenreId == id);
                genre.NomGenre = entity.NomGenre;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Genres.Remove(_context.Genres.First(g => g.GenreId == id));
            _context.SaveChanges();
        }
    }
}
