using DataLayer;
using DataLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositorios
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _context;

        public UserRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<USER> GetAll()
        {
            return _context.USER.ToList();
        }

        public USER GetById(int id)
        {
            return _context.USER.Find(id);
        }

        public void Create(USER user)
        {
            _context.USER.Add(user);
            _context.SaveChanges();

        }

        public void Update(USER user, int id)
        {
            USER userDb = _context.USER.Find(id);
            if (userDb != null)
            {
                userDb.NAME = user.NAME;
                userDb.LAST_NAME = user.LAST_NAME;
                userDb.EMAIL = user.EMAIL;
                userDb.PASSWORD = user.PASSWORD;
                userDb.ACTIVE = user.ACTIVE;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            USER userDB = _context.USER.Find(id);
            if(userDB != null)
            {
                _context.USER.Remove(userDB);
                _context.SaveChanges();
            }
        }
    }
}
