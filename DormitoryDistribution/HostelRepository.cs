using DormitoryDistribution.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DormitoryDistribution
{
    public static class HostelRepository
    {
        public static DormitoryDistributionContext _context = new DormitoryDistributionContext();

        public static void CreateHostels(Hostel hostel)
        {
            _context.Hostels.Add(hostel);
            _context.SaveChanges();
        }

        public static void UpdateHostels(Hostel hostel)
        {
            ContextDetached(hostel);
            _context.Entry(hostel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public static void DeleteHostels(Hostel hostel)
        {
            ContextDetached(hostel);
            _context.Entry(hostel).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public static List<Hostel> GetHostels()
        {
             return _context.Hostels.ToList();
        }

        //public static Hostel FindHostel(string login, string password)
        //{
        //    return _context.Hostels.FirstOrDefault(x => x.Login == login && x.Password == password);
        //}

        private static void ContextDetached(Hostel hostel)
        {
            var local = _context.Set<Hostel>().Local.FirstOrDefault(c => c.Id == hostel.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
        }
    }
}
