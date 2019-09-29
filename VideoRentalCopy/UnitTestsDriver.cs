using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalCopy
{
    public class UnitTestsDriver
    {
        public void ConnectionTest()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HPCQ490\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True");

            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                throw (new Exception("Connection cannot be established"));

            }



        }
        public void DataReadTest()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RF1HK0D\SQLEXPRESS; Initial Catalog=VideoRental; Integrated Security=True");
            //query to select all from movies
            SqlCommand cmd = new SqlCommand("Select * from Movies", con);
            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection = con;
            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                throw (new Exception("Read Test Failed"));

            }


        }

    }
}
