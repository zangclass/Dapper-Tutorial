using Dapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_in_Asp.Net_Core.Repository
{
    public class UserRepository : iUserRepository
    {
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        public List<UserEntity> GetUserList()
        {
            List<UserEntity> result;
            using(IDbConnection con = new SqlConnection(_connectionString))
            {
                var sql = "select * from dbo.tblUser;";
                result = con.Query<UserEntity>(sql).ToList();
            }
            return result;
        }
    }
}
