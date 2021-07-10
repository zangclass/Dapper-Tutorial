using FinalProject.Constract;
using FinalProject.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Linq;

namespace FinalProject.RepositoryDapper
{
    public class UserRepository : iUser
    {
        public void Add(UserEntity obj)
        {
            using (IDbConnection con = new SqlConnection(Comman.DbConnectionInfo.ConnectionStringAddress))
            {
                con.Execute("dbo.User_Execute", new
                {
                    Kind = 1,
                    FirstName = obj.FirstName,
                    LastName = obj.LastName,
                    Tel = obj.Tel
                }, null, null, CommandType.StoredProcedure);
            }
        }
        public void Edit(int id, UserEntity obj)
        {
            using (IDbConnection con = new SqlConnection(Comman.DbConnectionInfo.ConnectionStringAddress))
            {
                con.Execute("dbo.User_Execute", new
                {
                    Kind = 2,
                    Id = id,
                    FirstName = obj.FirstName,
                    LastName = obj.LastName,
                    Tel = obj.Tel
                }, null, null, CommandType.StoredProcedure);
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection con = new SqlConnection(Comman.DbConnectionInfo.ConnectionStringAddress))
            {
                con.Execute("dbo.User_Execute", new
                {
                    Kind = 3,
                    Id = id
                }, null, null, CommandType.StoredProcedure);
            }
        }

        public UserEntity GetSingleUser(int id)
        {
            using (IDbConnection con = new SqlConnection(Comman.DbConnectionInfo.ConnectionStringAddress))
            {
                return con.QueryFirstOrDefault<UserEntity>("dbo.User_Query", new
                {
                    Kind = 2,
                    Id = id
                }, null, null, CommandType.StoredProcedure);
            }
        }

        public List<UserEntity> GetUserList()
        {
            using (IDbConnection con = new SqlConnection(Comman.DbConnectionInfo.ConnectionStringAddress))
            {
                return con.Query<UserEntity>("dbo.User_Query",
                    new
                    {
                        Kind = 1
                    }, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }
    }
}
