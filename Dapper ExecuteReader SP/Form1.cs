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

namespace Dapper_ExecuteReader_SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void AddUser()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var result = con.ExecuteReader("dbo.User_Execute", new
                    {
                        Kind = 1,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Tel = txtTel.Text,
                    }, null, null, CommandType.StoredProcedure);
                    DataTable dt = new DataTable();
                    dt.Load(result);

                    if(dt.Rows.Count != 0)
                    {
                        lblResult.Text = dt.Rows[0][0].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
