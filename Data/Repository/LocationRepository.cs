using System.Collections.Generic;
using System.Linq;

using DeltaSchool.Data.Entity;
using DeltaSchool.Data.Repository.Interface;

namespace DeltaSchool.Data.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DeltaSchoolContext _context;

        public LocationRepository(DeltaSchoolContext context)
        {
            _context = context;
        }

        public IEnumerable<Sites> GetAll()
        {
            return _context.Locations.ToList();
        }

        public Sites GetById(int id)
        {
            return _context.Locations.Find(id);
        }

        public void Add(Sites location)
        {
            _context.Locations.Add(location);
        }

        public void Update(Sites location)
        {
            _context.Entry(location).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var location = _context.Locations.Find(id);
            if (location != null)
                _context.Locations.Remove(location);
        }

        public void Save() => _context.SaveChanges();
    }
}
