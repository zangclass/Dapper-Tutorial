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

namespace _07_QuerySingle_and_QuerySingleOrDefault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";
        private void GetQuerySingle()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var sql = "select * from dbo.tblUser where id = @id";
                    var result = con.QuerySingle<UserEntity>(sql,new { id = 1});
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnQuerySingle_Click(object sender, EventArgs e)
        {
            GetQuerySingle();
        }
        private void GetQuerySingleOrDefault()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var sql = "select * from dbo.tblUser where id >= @id";
                    var result = con.QuerySingleOrDefault<UserEntity>(sql, new { id = 7 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnQuerySingleOrDefault_Click(object sender, EventArgs e)
        {
            GetQuerySingleOrDefault();
        }
    }
}
