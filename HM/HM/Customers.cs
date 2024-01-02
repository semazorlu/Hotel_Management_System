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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sema Nur Zorlu\Documents\HotelDbase.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();

            string Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomersDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void EditCustomer()
        {
            if (CnameTb.Text == "" || GenderCb.SelectedIndex == -1 || phoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName=@CN,CustPhone=@CP,CustGender=@CG where CustNUm=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CN", CnameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", phoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated!!");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteCustomer()
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Customer!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl where CustNum = @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted!!");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void InsertCustomer()
        {
            if (CnameTb.Text == "" || GenderCb.SelectedIndex == -1 || phoneTb.Text == "")
            {
                MessageBox.Show("Missing Information!!");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustName,CustPhone,CustGender) values(@CN,@CP,@CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", CnameTb.Text);
                    cmd.Parameters.AddWithValue("@CP", phoneTb.Text);
                    cmd.Parameters.AddWithValue("@CG", GenderCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added!!");

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
            InsertCustomer();
        }

        int Key = 0;

        private void CustomersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CnameTb.Text = CustomersDGV.SelectedRows[0].Cells[1].Value.ToString();
            phoneTb.Text = CustomersDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = CustomersDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (CnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditCustomer();
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

        private void label7_Click(object sender, EventArgs e)
        {
            Bookings Obj = new Bookings();
            Obj.Show();
            this.Hide();
        }
    }
}
