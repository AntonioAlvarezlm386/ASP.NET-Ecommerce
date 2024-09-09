using BussinesLayer.Common;
using EntityLayer;
using System.Collections.Generic;

namespace BussinesLayer.Interfaces
{
    public interface IUserService
    {
        Result<List<USER>> GetAllUsers();
        Result<USER> GetUserById(int id);
        //Result<object> CreateUser(USER user);
        //Result<object> UpdateUser(USER user, int id);
        //Result<object> DeleteUser(int id);
    }
}
