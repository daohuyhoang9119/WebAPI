using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.User;

namespace WebAPI.Services.AuthService
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(string user, string password);
        Task<ServiceResponse<User>> Login(string useremail, string password);
        Task<bool> UserExits(string useremail);
         
    }
}