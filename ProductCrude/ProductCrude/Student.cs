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
using System.Configuration;
namespace ProductCrude
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Student()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
        private void ClearFileds()
        {
            txtId.Clear();
            txtName.Clear();
            txtemail.Clear();
            txtadd.Clear();
            txtmob.Clear();

        }
        private DataSet GetAllStudents()
        {
            DataSet ds = new DataSet();

            try
            {
                // Step 1 - Write Query
                string query = "SELECT * FROM student";

                // Step 2 - Create DataAdapter
                da = new SqlDataAdapter(query, con);

                // Step 3 - Add Primary Key to DataSet
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                // Step 4 - Create SqlCommandBuilder
                SqlCommandBuilder scb = new SqlCommandBuilder(da);

                // Step 5 - Fill DataSet with Data
                da.Fill(ds, "student");

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null; // Return null if an exception occurs
            }
            finally
            {
                con.Close(); // Ensure the connection is closed
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve DataSet
                DataSet ds = GetAllStudents();

                // Create new row to add record
                DataRow row = ds.Tables["student"].NewRow();
                row["name"] = txtName.Text; // Assuming txtName contains the name of the student
                row["email"] = txtemail.Text; // Assuming txtEmail contains the email of the student
                row["address"] = txtadd.Text; // Assuming txtAddress contains the address of the student
                row["mobile_no"] = txtmob.Text; // Assuming txtMobileNo contains the mobile number of the student

                // Attach row to the student table
                ds.Tables["student"].Rows.Add(row);

                // Update database
                int result = da.Update(ds.Tables["student"]);

                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve DataSet
                DataSet ds = GetAllStudents();

                // Find DataRow by Primary Key
                DataRow row = ds.Tables["student"].Rows.Find(txtId.Text);

                if (row != null)
                {
                    row["name"] = txtName.Text; // Assuming txtName contains the name of the student
                    row["email"] = txtemail.Text; // Assuming txtEmail contains the email of the student
                    row["address"] = txtadd.Text; // Assuming txtAddress contains the address of the student
                    row["mobile_no"] = txtmob.Text; // Assuming txtMobileNo contains the mobile number of the student

                    // Update Database
                    int result = da.Update(ds.Tables["student"]);

                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                        ClearFileds(); // Assuming ClearFields() clears the text boxes
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve DataSet
                DataSet ds = GetAllStudents();

                // Find DataRow by Primary Key
                DataRow row = ds.Tables["student"].Rows.Find(txtId.Text);

                if (row != null)
                {
                    // Delete DataRow
                    row.Delete();

                    // Update Database
                    int result = da.Update(ds.Tables["student"]);

                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFileds(); // Assuming ClearFields() clears the text boxes
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve DataSet
                DataSet ds = GetAllStudents();

                // Find DataRow by Primary Key
                DataRow row = ds.Tables["student"].Rows.Find(txtId.Text);

                if (row != null)
                {
                    // Display Record Values
                    txtName.Text = row["name"].ToString(); // Assuming txtName is the TextBox for displaying the student's name
                    txtemail.Text = row["email"].ToString(); // Assuming txtEmail is the TextBox for displaying the student's email
                    txtadd.Text = row["address"].ToString(); // Assuming txtAddress is the TextBox for displaying the student's address
                    txtmob.Text = row["mobile_no"].ToString(); // Assuming txtMobileNo is the TextBox for displaying the student's mobile number
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve DataSet containing student records
                DataSet ds = GetAllStudents();

                // Set DataGridView DataSource to the "student" DataTable in the DataSet
                dataGridView1.DataSource = ds.Tables["student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
