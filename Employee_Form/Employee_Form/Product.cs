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
    public partial class Product : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Product()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1 - Write query
                string qry = "INSERT INTO product (PName, Price) VALUES (@PName, @Price)";

                // Create command object and assign the query
                cmd = new SqlCommand(qry, con);

                // Assign values to parameters
                cmd.Parameters.AddWithValue("@PName", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);

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
                // step1 - write query
                string qry = "update product set PName=@PName,Price=@Price where PID=@PID";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@PName", txtName.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@PID", txtId.Text);
                // fire the query
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

                // step1 - write query 
                string qry = "delete from product where PID=@PID";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@PID", txtId.Text);
                // fire the query
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
                // step 1
                string qry = "select * from product where PID=@PID";
                // step2
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@PID", txtId.Text);
                //step3 execute the qry
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // whether row is present or not
                {
                    while (dr.Read()) // read row by row -- while loop or you can use if block to read single row
                    {
                        // read column
                        txtName.Text = dr["PName"].ToString();
                        txtPrice.Text = dr["Price"].ToString();
                        
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
                string query = "select * from product";
                cmd = new SqlCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                //reader hold the data in form of object 
                // to transfer it into table we use Datatable class because Gridview requires data in table format
                DataTable table = new DataTable();
                table.Load(dr);

                dataGridView1.DataSource = table;
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
    }
}
