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

namespace _08_QueryMultiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";
        private void GetQueryMultiple()
        {
            try
            {
                var sql = $"select * from dbo.tblUser where id = @id;" +
                    $"select * from dbo.tblUserProduct where UserId = @id;";
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    using (var obj= con.QueryMultiple(sql,new { id = 5}))
                    {
                        var user = obj.Read<UserEntity>().FirstOrDefault();
                        //var user = obj.ReadFirstOrDefault<UserEntity>();
                        var product = obj.Read<UserProductEntity>().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnQueryMultiple_Click(object sender, EventArgs e)
        {
            GetQueryMultiple();
        }
    }
}
