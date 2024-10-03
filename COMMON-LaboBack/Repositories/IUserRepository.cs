using COMMON_LaboBack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON_LaboBack.Repositories
{
    public interface IUserRepository<TUser> : ICRUDRepository<TUser, int> where TUser : IUser
    { 
    }
}
