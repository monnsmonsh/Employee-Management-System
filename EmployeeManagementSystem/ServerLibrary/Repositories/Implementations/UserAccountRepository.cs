using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ServerLibrary.Repositories.Contratcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repositories.Implementations
{
    internal class UserAccountRepository : IUserAccount
    {
        public Task<GeneralResponse> CreateAsync(Register user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> CreateAsync(Login user)
        {
            throw new NotImplementedException();
        }
    }
}
