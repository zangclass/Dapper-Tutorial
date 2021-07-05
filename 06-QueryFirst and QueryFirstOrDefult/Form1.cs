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

namespace _06_QueryFirst_and_QueryFirstOrDefult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        private void GetQueryFirst()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var sql = "Select * from dbo.tblUser where id = @id";
                    var result = con.QueryFirst<UserEntity>(sql, new { id = 1 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnQueryFirst_Click(object sender, EventArgs e)
        {
            GetQueryFirst();
        }
        private void GetQueryFirstOrDefult()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var sql = "Select * from dbo.tblUser where id = @id";
                    var result = con.QueryFirstOrDefault<UserEntity>(sql, new { id = 1 });
                    if (result != null)
                    {
                        MessageBox.Show("found");
                    }
                    else
                    {
                        MessageBox.Show("not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnQueryFirstOrDefult_Click(object sender, EventArgs e)
        {
            GetQueryFirstOrDefult();
        }
    }
}
