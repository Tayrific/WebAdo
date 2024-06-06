using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAdo
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<center><h1>Delete Customers</h1></center><hr/>");
            Response.Write("<br/>");

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            string customerId = txtInputID.Text;

            // Validate if the entered customer ID is not empty
            if (!string.IsNullOrEmpty(customerId))
            {
                string s = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

                // SQL query to delete the customer based on the entered customer ID
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlConnection con = new SqlConnection(s))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        con.Open();
                        try
                        {
                            
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Customer successfully deleted
                                Response.Write("<script>alert('Customer deleted successfully.');</script>");
                            }
                            else
                            {
                                // Customer not found or could not be deleted
                                Response.Write("<script>alert('Customer not found or could not be deleted.');</script>");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions
                            Response.Write("<script>alert('An error occurred while deleting the customer.');</script>");
                        }
                        con.Close();
                    }
                }
            }
            else
            {
                // Display a message if no customer ID is entered
                Response.Write("<script>alert('Please enter a customer ID to delete.');</script>");
            }           
        }
    }
}