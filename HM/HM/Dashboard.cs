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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountRooms();
            CountCustomers();
            SumAmount();
            GetCustomers();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Sema Nur Zorlu\Documents\HotelDbase.mdf"";Integrated Security=True;Connect Timeout=30");

        private void CountRooms()
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from RoomTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RoomsLbl.Text = dt.Rows[0][0].ToString() + "   Rooms";

            Con.Close();
        }

        private void CountCustomers()
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CustLbl.Text = dt.Rows[0][0].ToString() + "   Customers";

            Con.Close();
        }

        private void SumAmount()
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select sum(Cost) from BookingTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BookingLbl.Text = "Rs  " + dt.Rows[0][0].ToString();

            Con.Close();
        }

        private void SumDaily()
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select sum(Cost) from BookingTbl where BokeDate='" + BDate.Value.Date + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DincomeLbl.Text = "Rs  " + dt.Rows[0][0].ToString();

            Con.Close();
        }

        private void SumByCustomer()
        {
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("select sum(Cost) from BookingTbl where Customer=" + CustomerCb.SelectedValue.ToString() + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                IncomeByCustLbl.Text = "Rs  " + dt.Rows[0][0].ToString();

                Con.Close();
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetCustomers()
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("select * from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustNum", typeof(int));
            dt.Load(rdr);
            CustomerCb.ValueMember = "CustNum";
            CustomerCb.DataSource = dt;

            Con.Close();
        }

        private void BDate_ValueChanged(object sender, EventArgs e)
        {
            SumDaily();
        }

        private void CustomerCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumByCustomer();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Types Obj = new Types();
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

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
