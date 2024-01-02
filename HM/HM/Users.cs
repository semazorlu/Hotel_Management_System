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
using System.Windows.Input;

namespace HM
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUsers();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sema Nur Zorlu\Documents\HotelDbase.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();

            string Query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void EditUsers()
        {
            if (UnameTb.Text == "" || GenderCb.SelectedIndex == -1 || PasswordTb.Text == "" || UphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("update UserTbl set UName=@UN,UPhone=@UP,UGender=@UG,UPassword=@UPa where UNum=@UKey", Con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UP", UphoneTb.Text);
                    cmd.Parameters.AddWithValue("@UG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated!!");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteUsers()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a User!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("delete from UserTbl where UNum = @UKey", Con);
                    cmd.Parameters.AddWithValue("@UKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted!!");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void InsertUsers()
        {
            if (UnameTb.Text == "" || GenderCb.SelectedIndex == -1 || PasswordTb.Text == "" || UphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into UserTbl(UName,UPhone,UGender,UPassword) values(@uN,@UP,@UG,@UPa)", Con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UP", UphoneTb.Text);
                    cmd.Parameters.AddWithValue("@UG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@UPa", PasswordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added!!");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            InsertUsers();
        }

        int Key = 0;

        private void RoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UphoneTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (UnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditUsers();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Types Obj = new Types();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Bookings Obj = new Bookings();
            Obj.Show();
            this.Hide();
        }
    }
}
