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
    public partial class Movie : Form
    {
        public Movie()
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
            SqlCommand cmd = new SqlCommand("Select * from Movies", con);

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
            string ratingg = rating.Text;
            string titlee = title.Text;
            string yearr = year.Text;
            string rentalcostt = rentalcost.Text;

            string copiess = copies.Text;
            string plott = plot.Text;
            string genree = plot.Text;
            //Data of all text boxes is got
            rating.Text = "";
            title.Text = "";
            year.Text = "";
            rentalcost.Text = "";
            copies.Text = "";
            plot.Text = "";
            genre.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into Movies VALUES (@rating, @title, @year,@rentalcost, @copies,@plot,@genre)");
            cmd.Parameters.AddWithValue("@rating", ratingg);
            cmd.Parameters.AddWithValue("@title", titlee);
            cmd.Parameters.AddWithValue("@year", yearr);
            cmd.Parameters.AddWithValue("@rentalcost", rentalcostt);
            cmd.Parameters.AddWithValue("@copies", copiess);
            cmd.Parameters.AddWithValue("@plot", plott);
            cmd.Parameters.AddWithValue("@genre", genree);

            //query to insert all data into movies

            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string movieidd = movieid.Text;
            movieid.Text = "";

            //movie id is got


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("DELETE from Movies where MovieID=@movieid");
            cmd.Parameters.AddWithValue("@movieid", movieidd);

            




            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed to delete movie
            Console.WriteLine(recordsAffected);
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string movieidd = upid.Text;
            string titlee = uptitle.Text;
            string yearr = upyear.Text;
            //all data of textbox is got
            upid.Text = "";
            uptitle.Text = "";
            upyear.Text = "";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("UPDATE Movies SET Title=@title,Year=@year where MovieID=@movieid");
            cmd.Parameters.AddWithValue("@title", titlee);
            cmd.Parameters.AddWithValue("@year", yearr);
            cmd.Parameters.AddWithValue("@movieid", movieidd);


            //query parameter are added


            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string custidd = rcid.Text;
            string movieidd = rid.Text;
            rcid.Text = "";
            rid.Text = "";

            //customer and movie id is got

            DateTime aDate = DateTime.Now.Date;
            //get current data and time

            string returndate = aDate.ToString("yyyy/MM/dd HH:mm::ss");
            //2014 - 04 - 09 15:30:03.447
            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = ("UPDATE RentedMovies SET DateReturned=@returndate where MovieIDFK=@movieid and CustIDFK=@custid;");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@custid", custidd);
            cmd.Parameters.AddWithValue("@returndate", returndate);

            //update query to update date returned column



            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(recordsAffected);
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");
            string custidd = iid.Text;
            string movieidd = icid.Text;
            //customer id and movieid is got from text box
            iid.Text = "";
            icid.Text = "";
            DateTime aDate = DateTime.Now.Date;

            //current time is got
            string issuedate = aDate.ToString("yyyy/MM/dd HH:mm::ss");
            //2014 - 04 - 09 15:30:03.447


            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);





            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = ("INSERT into RentedMovies VALUES (@movieid, @custid, @daterented,NULL)");
            cmd.Parameters.AddWithValue("@movieid", movieidd);
            cmd.Parameters.AddWithValue("@custid", custidd);
            cmd.Parameters.AddWithValue("@daterented", issuedate);

            con.Open();
            int recordsAffected = cmd.ExecuteNonQuery();
            //query is executed to insert record
            Console.WriteLine(recordsAffected);
            con.Close();
        }
    }
}
