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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from Movies where Rating='G'", con);


            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;



            DataTable dt = new DataTable();

            da.Fill(dt);

            //data adapter is filled with rows
            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;
            //data is binded to data grid view

            gridview1.DataSource = bsource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(" SELECT TOP 1 CustIDFK FROM RentedMovies GROUP BY CustIDFK ORDER BY count(CustIDFK) desc; ", con);
            con.Open();

            Int32 custId = 2;
            //query is executed using reader
            using (var reader = cmd.ExecuteReader())
            {


                while (reader.Read())
                {
                    custId = reader.GetInt32(0);

                    break;
                }
            }
            //customer id with max borrowing is got
            con.Close();

            con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            cmd = new SqlCommand("Select * from Customer where CustID=@custid", con);
            cmd.Parameters.AddWithValue("@custid", custId);
            //select all details of that customer
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            //bind the data of that customer to datagridview
            da.Fill(dt);

            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;

            gridview2.DataSource = bsource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("  Select Movies.* from Movies inner join RentedMovies on RentedMovies.MovieIDFK=Movies.MovieID  where RentedMovies.DateReturned is  null", con);

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource bsource = new BindingSource();

            bsource.DataSource = dt;

            gridview3.DataSource = bsource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VideoRentalCopy.MovieCharges[] allRecords = null;

            //connection to db is made
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            //2014 - 04 - 09 15:30:03.447
            //DateTime dt = new DateTime(s);
            //issuedate =Convert.ToDateTime(s);



            SqlCommand cmd = new SqlCommand("Select MovieID,Title,Year from Movies", con);
            con.Open();
            //query is executed


            using (var reader = cmd.ExecuteReader())
            {

                var list = new List<VideoRentalCopy.MovieCharges>();
                while (reader.Read())
                {
                    Int32 movieid = reader.GetInt32(0);
                    String title = reader.GetString(1);

                    String year;

                    //get year of date issued


                    if (reader.IsDBNull(2))
                        year = "";
                    else
                        year = reader.GetString(2);
                    //if (myyear >= 2014)

                    //{
                    //add fees of 5 incase of movie older than 5 years
                    if (year != "")
                        list.Add(new VideoRentalCopy.MovieCharges { MovieId = movieid, Title = title, Year = year, fees = 5 });
                    
                    //else add fees of 2
                    else
                        list.Add(new VideoRentalCopy.MovieCharges { MovieId = movieid, Title = title, Year = year, fees = 2 });
                    allRecords = list.ToArray();
                }
            }
            
            //show record in gridview
            gridview4.DataSource = allRecords;
            
            con.Close();
        }
    }
}
