using Dapper;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Execute_Many
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        private void Save()
        {
            var userList = new List<UserEntity>();
            userList.Add(new UserEntity { FirstName = "farid", LastName = "Ghanbari", Tel = "0941111" });
            userList.Add(new UserEntity { FirstName = "mamli", LastName = "rashidi", Tel = "6545656" });
            userList.Add(new UserEntity { FirstName = "parsa", LastName = "fallah", Tel = "5451" });

            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                con.Execute("dbo.AddUser", userList, null, null, CommandType.StoredProcedure);
            }
        }
        private void btnSaveAddHoc_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
