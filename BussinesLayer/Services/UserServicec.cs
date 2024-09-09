using BussinesLayer.Interfaces;
using EntityLayer;
using DataLayer.Interfaces;
using System.Collections.Generic;
using BussinesLayer.Common;
using System.Diagnostics;
using System.Linq;
using System;

namespace BussinesLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Result<List<USER>> GetAllUsers()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                List<USER> users = _userRepository.GetAll().ToList();
                stopwatch.Stop();

                return Result<List<USER>>.Succes(users, null, stopwatch.ElapsedMilliseconds);
            } catch (Exception ex)
            {
                stopwatch.Stop();

                return Result<List<USER>>.Failure(
                    "Error al obtener usuarios",
                    500,
                    "USR001",
                    "Critical",
                    ex,
                    stopwatch.ElapsedMilliseconds
                    );
            }
        }

        public Result<USER> GetUserById(int id)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                USER user = _userRepository.GetById(id);
                stopwatch.Stop();

                return Result<USER>.Succes(user, null, stopwatch.ElapsedMilliseconds);
            } catch (Exception ex)
            {
                stopwatch.Stop();

                return Result<USER>.Failure(
                    "Error al obtner el usuario",
                    500,
                    "USR002",
                    "Critical",
                    ex,
                    stopwatch.ElapsedMilliseconds
                    );
            };
        }

        //public Result<object> CreateUser(USER user) 
        //{
        //    _userRepository.Create(user);
        //}

        //public Result<object> UpdateUser(USER user, int id)
        //{
        //    _userRepository.Update(user, id);
        //}

        //public Result<object> DeleteUser(int id)
        //{
        //    _userRepository.Delete(id);
        //}
    }
}
 