using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Interfaces
{
    public interface IUserService
    {
        IEnumerable<USER> GetAllUsers();
        USER GetUserById(int id);
        void CreateUser(USER user);
        void UpdateUser(USER user, int id);
        void DeleteUser(int id);
    }
}
