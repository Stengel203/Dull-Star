using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DullStarData.DAL;

namespace DullStarData.Repositories
{
    public class UserRepository
    {
        private DullStarDevEntities _context;

        public UserRepository()
        {
            _context = new DullStarDevEntities();
        }

        public UserRepository(DullStarDevEntities context)
        {
            _context = context;
        }

        public void createUser(string Id, string UserName, DateTime BirthDate)
        {
            Users user = new Users
            {
                ANU_Id = Id,
                UserName = UserName,
                BirthDate = BirthDate
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
