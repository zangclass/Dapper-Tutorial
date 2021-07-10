using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Constract
{
    public interface iUser
    {
        void Add(UserEntity obj);
        void Edit(int id, UserEntity obj);
        void Delete(int id);
        UserEntity GetSingleUser(int id);
        List<UserEntity> GetUserList();
    }
}
