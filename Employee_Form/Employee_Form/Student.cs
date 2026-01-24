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
namespace Employee_Form
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Student()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write query
                string qry = "INSERT INTO student (name, email, address, mobile_no) VALUES (@Name, @Email, @Address, @MobileNo)";

                // Create command object and assign the query
                cmd = new SqlCommand(qry, con);

                // Assign values to parameters
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Address", txtadd.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txtmob.Text);

                // Execute the query
                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write query
                string qry = "UPDATE student SET name=@Name, email=@Email, address=@Address, mobile_no=@MobileNo WHERE id=@ID";

                // Create command object and assign the query
                cmd = new SqlCommand(qry, con);

                // Assign values to parameters
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Address", txtadd.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txtmob.Text);

                cmd.Parameters.AddWithValue("@ID", txtId.Text); // Assuming txtID contains the ID of the student to be updated

                // Execute the query
                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write query
                string qry = "DELETE FROM student WHERE id=@ID";

                // Create command object and assign the query
                cmd = new SqlCommand(qry, con);

                // Assign value to parameter
                cmd.Parameters.AddWithValue("@ID", txtId.Text); // Assuming txtID contains the ID of the student to be deleted

                // Execute the query
                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write Query
                string qry = "SELECT * FROM student WHERE id=@ID";

                // Step 2 - Create Command Object and Assign Parameters
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@ID", txtId.Text); // Assuming txtID contains the student ID entered by the user

                // Step 3 - Execute the Query and Retrieve Data
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows) // Check if any rows are returned by the query
                {
                    while (dr.Read()) // Read each row
                    {
                        // Read and display column values
                        txtName.Text = dr["name"].ToString();
                        txtemail.Text = dr["email"].ToString();
                        txtadd.Text = dr["address"].ToString();
                        txtmob.Text = dr["mobile_no"].ToString();
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
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write Query
                string query = "SELECT * FROM student";

                // Step 2 - Create Command Object and Execute Query
                cmd = new SqlCommand(query, con);

                // Step 3 - Open Connection and Execute Reader
                con.Open();
                dr = cmd.ExecuteReader();

                // Step 4 - Read Data and Load into DataTable
                DataTable table = new DataTable();
                table.Load(dr);

                // Step 5 - Display Data in DataGridView
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Step 6 - Close Connection
                con.Close();
            }
        }
    }
}
