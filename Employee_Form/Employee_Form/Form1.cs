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
using System.Configuration;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;



namespace Employee_Form
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - write query
                string qry = "insert into employee values(@name,@city,@salary)";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                // fire the query
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
                string qry = "update employee set name=@name,city=@city,salary=@salary where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
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
                string qry = "delete from employee where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@id", txtId.Text);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from employee";
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

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // step 1
                string qry = "select * from employee where id=@id";
                // step2
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                //step3 execute the qry
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // whether row is present or not
                {
                    while (dr.Read()) // read row by row -- while loop or you can use if block to read single row
                    {
                        // read column
                        txtName.Text = dr["name"].ToString();
                        txtCity.Text = dr["city"].ToString();
                        txtSalary.Text = dr["salary"].ToString();
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
    }
}
