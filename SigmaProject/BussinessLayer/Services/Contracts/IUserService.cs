﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace BussinessLayer.Services.Contracts
{
    public interface IUserService :IBaseService<User>
    {
        Task<User> GetByUserNameAndPass(string _username, string _password);
        string GetEncryptedPassword(string _pass);
    }
}
