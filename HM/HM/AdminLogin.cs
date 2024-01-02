using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void ContinueLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Admin Password!!");
            }
            else
            {
                if (PasswordTb.Text == "Password")
                {
                    Users Obj = new Users();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin Password!!");
                }
            }
        }
    }
}
