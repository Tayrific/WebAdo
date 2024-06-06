using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAdo
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("<center><h1>Add Customer to database</h1></center><hr/>");
                Response.Write("<br/>");

                string s = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                
                string sqlStringDropDownList = "select Country from customers";
                SqlCommand cmd2 = new SqlCommand(sqlStringDropDownList, con);

                con.Open();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read() == true)
                {
                    listCountry.Items.Add(new ListItem(dr2["Country"].ToString(), dr2["Country"].ToString()));
                }
                dr2.Close();

                con.Close();
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string customerId = txtID.Text;
            string companyName = txtCompName.Text;
            string contactName = TextBox2.Text;
            string contactTitle = txtConTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string postalCode = txtPostal.Text;
            string country = listCountry.SelectedValue;
            string phone = txtPhone.Text;

            string s = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection con = new SqlConnection(s);

            string sqlString = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, PostalCode, Country, Phone)" +
                               "VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @PostalCode, @Country, @Phone)";

            SqlCommand cmd = new SqlCommand(sqlString, con);

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@CompanyName", companyName);
            cmd.Parameters.AddWithValue("@ContactName", contactName);
            cmd.Parameters.AddWithValue("@ContactTitle", contactTitle);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@PostalCode", postalCode);
            cmd.Parameters.AddWithValue("@Country", country);
            cmd.Parameters.AddWithValue("@Phone", phone);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                Response.Write("<script>alert('Customer added successfully.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed to add customer.');</script>");
            }
        }
    }
}