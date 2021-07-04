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

namespace _01_Execute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _connectionString = "Server=.; Database=DapperDB; Trusted_Connection=True;";

        private void SaveAddHoc()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    var sql = "insert into dbo.tblUser (FirstName,LastName,Tel) values (@FristName,@LastName,@Tel)";
                    con.Execute(sql, new
                    {
                        FristName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Tel = txtTel.Text
                    });
                }
                MessageBox.Show("درج با موفقیت انجام شد.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void SaveSp()
        {
            try
            {
                using (IDbConnection con = new SqlConnection(_connectionString))
                {
                    //con.ExecuteAsync()
                   await con.ExecuteAsync("dbo.AddUser", new
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Tel = txtTel.Text
                    }, null, null, CommandType.StoredProcedure);

                }
                MessageBox.Show("درج با موفقیت انجام شد.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveAddHoc_Click(object sender, EventArgs e)
        {
            SaveAddHoc();
        }

        private void btnSaveSp_Click(object sender, EventArgs e)
        {
            SaveSp();
        }
    }
}
