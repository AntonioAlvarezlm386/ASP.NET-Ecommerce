using BussinesLayer.Interfaces;
using EntityLayer;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace BussinesLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<USER> GetAllUsers()
        {
            IEnumerable<USER> users = _userRepository.GetAll();
            return users;
        }

        public USER GetUserById(int id)
        {
            USER userDb = _userRepository.GetById(id);
            return userDb;
        }

        public void CreateUser(USER user) 
        {
            _userRepository.Create(user);
        }

        public void UpdateUser(USER user, int id)
        {
            _userRepository.Update(user, id);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
 