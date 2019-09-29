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
    public partial class Rentals : Form
    {
        public Rentals()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("Select * from RentedMovies", con);

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
            //Connection to database is made

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string movieidd = movieid.Text;
            string customeridd = custid.Text;
            string daterentedd = drented.Text;
            string datereturnedd = dreturned.Text;
            //all data is of text boxes is got
            movieid.Text = "";
            custid.Text = "";
            drented.Text = "";
            dreturned.Text = "";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into RentedMovies VALUES (@movieid, @customerid, @daterented,@datereturned)");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@customerid", customeridd);
            cmd.Parameters.AddWithValue("@daterented", daterentedd);
            cmd.Parameters.AddWithValue("@datereturned", datereturnedd);

            //query to insert all data is executed
            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to database is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string rmid = dmid.Text;
            string mid = dcid.Text;
            //movie and cusomer id from textbox is got
            dmid.Text = "";
            dcid.Text = "";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("DELETE from RentedMovies where RMID=@rentedid and MovieIDFK=@movieid");
            cmd.Parameters.AddWithValue("@movieid", mid);
            cmd.Parameters.AddWithValue("@rentedid", rmid);




            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query to delete rows is executed
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string rmovieidd = rrmid.Text;
            string movieidd = rmid.Text;
            string custidd = rcid.Text;
            //all data of textbox is got

            rrmid.Text = "";
            rmid.Text = "";
            rcid.Text = "";



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("UPDATE RentedMovies SET CustIDFK=@custid,MovieIDFK=@movieid where RMID=@rmovieid");
            cmd.Parameters.AddWithValue("@custid", custidd);
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@rmovieid", rmovieidd);
            //query paramenters are added




            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed
            Console.WriteLine(recordsAffected);
            con.Close();
        }
    }
}
