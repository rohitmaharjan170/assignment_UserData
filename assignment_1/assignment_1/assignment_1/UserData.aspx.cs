using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment_1
{
    public partial class UserData : System.Web.UI.Page
    {
        string gender;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text.Trim();
            string LastName = txtLastName.Text.Trim();
            string Email= txtEmail.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string Mobile = txtMobile.Text.Trim();
            


            // Validation 
            if (FirstName == "")
            {
                errFirstName.Visible = true;
                txtFirstName.Focus();
            }
            else
            {
                errFirstName.Visible = false;
            }

            if (LastName == "")
            {
                errLastName.Visible = true;
                txtLastName.Focus();
            }
            else
            {
                errLastName.Visible = false;
            }

            if (Email == "")
            {
                errEmail.Visible = true;
                txtEmail.Focus();
            }
            else
            {
                errEmail.Visible = false;
            }

            if (Address == "")
            {
                errAddress.Visible = true;
                txtAddress.Focus();
            }
            else
            {
                errAddress.Visible = false;
            }
            if (Mobile == "")
            {
                errMobile.Visible = true;
                txtMobile.Focus();
            }
            else
            {
                errMobile.Visible = false;
            }

            if (radFemale.Checked == true)
            {
                gender = "F";
                errGender.Visible = false;
            }
            else if (radMale.Checked == true)
            {
                gender = "M";
                errGender.Visible = false;
            }
            else
            {
                errGender.Visible = true;
            }

            // end of text field and radio button validation

            if (FirstName != "" && LastName != "" && Address != "" && Mobile != "" && Email != "" && gender != "")
            {
                string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rmaha\Desktop\assignment_1\assignment_1\assignment_1\App_Data\login.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO UserData ( FirstName, LastName, Email, Mobile, Address, Gender) VALUES( @FName, @LName, @Email, @Mobile, @Address, @Gender) ", con);
                //  cmd.Parameters.AddWithValue("@Stu_ID", null);
                cmd.Parameters.AddWithValue("@FName", FirstName);
                cmd.Parameters.AddWithValue("@LName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Mobile", Mobile);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Gender", gender);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                btnReset_Click(null, null);

                Response.Write("<script>alert('Saved Successfully);</script>");
                Response.Write("<script LANGUAGE='JavaScript' >alert('Saved Successfully')</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            radFemale.Checked = false;
            radMale.Checked = false;
        }
    }
}