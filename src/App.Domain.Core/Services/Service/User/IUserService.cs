﻿using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Service.User
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAll();
        Task<UserDto> GetByName(string name);
        Task<List<string>> GetAllRoles();
    }
}
