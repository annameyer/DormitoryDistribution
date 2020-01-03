using DormitoryDistribution.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DormitoryDistribution
{
    public static class UserRepository
    {
        public static DormitoryDistributionContext _context = new DormitoryDistributionContext();

        public static void CreateUsers(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public static void UpdateUsers(Users user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public static void DeleteUsers(Users user)
        {
            _context.Entry(user).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public static List<Users> GetUsers()
        {
             return _context.Users.ToList();
        }

        public static Users FindUser(string login, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
        }
    }
}
