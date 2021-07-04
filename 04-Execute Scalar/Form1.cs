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

namespace _04_Execute_Scalar
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
            GetRowCoutUser();
        }

        private void GetRowCoutUser()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var result = con.ExecuteScalar<string>("select * from dbo.tblUser");
                    MessageBox.Show($"row cout is => {result}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
