using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDataContext _context;

        public PlatformRepo (AppDataContext context)
        {
            _context = context;
        }

        public void CreatePlatform(Platform plat)
        {
            if(plat == null)
            {
                throw new System.NotImplementedException();
            }

            _context.Platforms.Add(plat);
             
        }
        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}