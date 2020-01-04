using DormitoryDistribution.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DormitoryDistribution
{
    public static class HostelRepository
    {
        public static DormitoryDistributionContext _context = new DormitoryDistributionContext();
        public static bool LastNameChecked { get; set; }
        public static bool FirstNameChecked { get; set; }
        public static bool GroupNameChecked { get; set; }
        public static bool AverageMarkChecked { get; set; }
        public static bool IncomeChecked { get; set; }
        public static string Search { get; set; }
        public static bool Sort { get; set; }
        public static decimal MinSalary { get; set; }

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
            var hostel = _context.Hostels.ToList();
            if (MinSalary != 0)
            {
                return AccommodationAtTheHostel();
            }
            if (Sort)
            {
                hostel = SortHostel(hostel);
            }
            if (!string.IsNullOrEmpty(Search))
            {
                hostel = SearchHostel(hostel);
            }

            return hostel;
        }

        public static List<Hostel> SearchHostel(List<Hostel> hostels)
        {
            if (LastNameChecked)
            {
                return hostels.Where(x => x.LastName.Contains(Search)).ToList();
            }
            else if (FirstNameChecked)
            {
                return hostels.Where(x => x.FirstName.Contains(Search)).ToList();
            }
            else
            if (GroupNameChecked)
            {
                return hostels.Where(x => x.Group.Contains(Search)).ToList();
            }
            else
            if (AverageMarkChecked)
            {
                return hostels.Where(x => x.AverageMark == double.Parse(Search)).ToList();
            }
            else if (IncomeChecked)
            {
                return hostels.Where(x => x.Income == decimal.Parse(Search)).ToList();
            }

            return hostels;
        }

        public static List<Hostel> SortHostel(List<Hostel> hostels)
        {
            if (LastNameChecked)
            {
                return hostels.OrderBy(x => x.LastName).ToList();
            }
            else if (FirstNameChecked)
            {
                return hostels.OrderBy(x => x.FirstName).ToList();
            }
            else
            if (GroupNameChecked)
            {
                return hostels.OrderBy(x => x.Group).ToList();
            }
            else
            if (AverageMarkChecked)
            {
                return hostels.OrderBy(x => x.AverageMark).ToList();
            }
            else if (IncomeChecked)
            {
                return hostels.OrderBy(x => x.Income).ToList();
            }

            return hostels;
        }

        private static void ContextDetached(Hostel hostel)
        {
            Hostel local = _context.Set<Hostel>().Local.FirstOrDefault(c => c.Id == hostel.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
        }

        public static List<Hostel> AccommodationAtTheHostel()
        {
            return _context.Hostels.OrderByDescending(x => x.Income < (MinSalary * 2)).ThenBy(x => x.AverageMark).ThenByDescending(x => x.Activities).ToList();
        }
    }
}
