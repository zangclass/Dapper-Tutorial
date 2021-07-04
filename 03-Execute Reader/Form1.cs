using Dapper;
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

namespace _03_Execute_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";


        private void btnList_Click(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void GetUserList()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var q = $"insert into dbo.tblUser (" +
                        $"FirstName,LastName,Tel) values(" +
                        $"'hasan','alavi','1255555');" +
                        $"select top 1 Id from dbo.tblUser " +
                        $"ORDER BY Id DESC";
                    var lst = con.ExecuteReader(q);

                    DataTable dt = new DataTable();
                    dt.Load(lst);
                    int a = 10;
                    a++;
                    //dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
