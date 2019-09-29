using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoRentalCopy
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            //query to select all from movies
            SqlCommand cmd = new SqlCommand("Select * from Customer", con);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            BindingSource bsource = new BindingSource();
            //data is binded to gridview
            bsource.DataSource = dt;

            gridview.DataSource = bsource;
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string firstname = fname.Text;
            string lastname = lname.Text;
            string addres = address.Text;
            string phon = phone.Text;

            fname.Text = "";
            lname.Text = "";
            address.Text = "";
            phone.Text = "";
            //add data of textboxes is got
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into Customer VALUES (@firstname, @lastname, @addres,@phon)");
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@addres", addres);
            cmd.Parameters.AddWithValue("@phon", phon);

            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            //query is executed to insert data
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //connection to database is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string custidd = custid.Text;
            custid.Text = "";
            //customer id is got from text box

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("DELETE from Customer where CustID=@custid");
            cmd.Parameters.AddWithValue("@custid", custidd);



            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //Query is executed to delete user 
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string ucid = this.ucid.Text;
            string fname = ufname.Text;
            string lname = ualname.Text;
            this.ucid.Text = "";
            ufname.Text = "";
            ualname.Text = "";

            //all textbox data is got


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("UPDATE Customer SET FirstName=@fname,LastName=@lname where CustID=@custid");
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@custid", ucid);




            //sql query to update all results
            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query executed
            Console.WriteLine(recordsAffected);
            con.Close();
        }
    }
}
