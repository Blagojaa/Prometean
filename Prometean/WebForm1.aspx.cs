using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Prometean
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Prometean;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        void GridViewFill(SqlConnection con)
        {
            string query = "SELECT * FROM Trupe";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;

            GridView1.DataBind();

            reader.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Blagoja" && TextBox2.Text == "seljak")
            {
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;


                Button2.Visible = true;
            }
            try
            {
                using (con)
                {
                    con.Open();

                    GridViewFill(con);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox3.Text);
            int cost = Convert.ToInt32(TextBox4.Text);
            using (con)
            {
                con.Open();

                SqlParameter p1 = new SqlParameter();
                SqlParameter p2 = new SqlParameter();


                p1.Value = id;
                p2.Value = cost;

                p1.ParameterName = "@id";
                p2.ParameterName = "@cost";

                string query = "UPDATE Trupe " +
                                " SET Resursi = @cost " +
                                " WHERE MythunitsID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                string query2 = "SELECT * FROM Trupe";

                SqlCommand cmd2 = new SqlCommand(query2, con);

                SqlDataReader reader2 = cmd2.ExecuteReader();

                GridView1.DataSource = reader2;

                GridView1.DataBind();

                reader2.Close();


            }

        }
    }
}


