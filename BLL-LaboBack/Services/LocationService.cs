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
    public class LocationService : ILocationRepository<Location>
    {
        private DataContext _context;

        public LocationService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Location> Get()
        {
            try
            {
                return _context.Locations.Select(l => l.ToBLL());
            }
            catch (Exception ex)
            {
                return new List<Location>();
            }
        }

        public Location Get(int id)
        {
            try
            {
                return _context.Locations.First(l => l.LocationId == id).ToBLL();
            }
            catch (Exception ex)
            {
                return new Location();
            }
        }

        public bool Insert(Location entity)
        {
            try
            {
                _context.Locations.Add(entity.ToEF());
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Update(int id, Location entity)
        {
            try
            {
                var location = _context.Locations.First(l => l.LocationId == id);
                location.DebutLocation = entity.DebutLocation;
                location.RetourLocation = entity.RetourLocation;
                location.Prix = entity.Prix;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Tu as encore tout raté !");
            }
        }

        public void Delete(int id)
        {
            _context.Locations.Remove(_context.Locations.First(l => l.LocationId == id));
            _context.SaveChanges();
        }
    }
}
