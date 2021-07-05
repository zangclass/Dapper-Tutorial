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

namespace _05_Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void GetUserList()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var lst = con.Query<UserEntity>("dbo.UserList", null, null, true, 
                                                null, CommandType.StoredProcedure).
                                                Where(f => f.Id >= 7).ToList();

                    dataGridView1.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
