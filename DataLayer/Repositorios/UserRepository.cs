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
            try
            {
                List<USER> usersDb = _context.USER.ToList();

                return usersDb;
            } catch(Exception ex)
            {
                return Enumerable.Empty<USER>();
            }
        }

        public USER GetById(int id)
        {
            try
            {
                USER userDb = _context.USER.Find(id);
                return userDb;
            } catch(Exception ex)
            {
                return null;
            }
        }

        public bool Create(USER user)
        {
            try
            {
                _context.USER.Add(user);
                _context.SaveChanges();

                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(USER user, int id)
        {
            try
            {
                USER userDb = _context.USER.Find(id);
                if (userDb != null)
                {
                    userDb.NAME = user.NAME;
                    userDb.LASTTNAME = user.LASTTNAME;
                    userDb.EMAIL = user.EMAIL;
                    userDb.PASSWORD = user.PASSWORD;
                    userDb.ACTIVE = user.ACTIVE;

                    _context.SaveChanges();


                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                USER userDB = _context.USER.Find(id);
                if(userDB != null)
                {
                    _context.USER.Remove(userDB);
                    _context.SaveChanges();

                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
