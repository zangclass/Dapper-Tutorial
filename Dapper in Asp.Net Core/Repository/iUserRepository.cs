﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_in_Asp.Net_Core.Repository
{
    public interface iUserRepository
    {
        List<UserEntity> GetUserList();
    }
}
