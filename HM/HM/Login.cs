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

namespace HM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sema Nur Zorlu\Documents\HotelDbase.mdf"";Integrated Security=True;Connect Timeout=30");

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName='" + UnameTb.Text + "' and UPassword='" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Rooms Obj = new Rooms();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password!!");
                    }

                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ContinueLbl_Click(object sender, EventArgs e)
        {
            AdminLogin Obj = new AdminLogin();
            Obj.Show();
            this.Hide();
        }
    }
}
