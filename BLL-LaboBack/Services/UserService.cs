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
    public class UserService : IUserRepository<User>
    {
        private DataContext _context;

        public UserService(DataContext context) 
        {
            _context = context;
        }

        public IEnumerable<User> Get()
        {
            try
            {
                return _context.Users.Select(u => u.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }

        public User Get(int id)
        {
            try
            {
                return _context.Users.First(u => u.UserId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new User();
            }
        }

        public bool Insert(User entity)
        {
            try
            {
                _context.Users.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, User entity)
        {
            try
            {
                var user = _context.Users.First(u => u.UserId == id);
                user.Nom = entity.Nom;
                user.Prenom = entity.Prenom;
                user.Rue = entity.Rue;
                user.Numero = entity.Numero;
                user.Localite = entity.Localite;
                user.CodePostal = entity.CodePostal;
                user.Pays = entity.Pays;
                user.Email = entity.Email;
                user.MDP = entity.MDP;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Users.Remove(_context.Users.First(u => u.UserId == id));
            _context.SaveChanges();
        }
    }
}
