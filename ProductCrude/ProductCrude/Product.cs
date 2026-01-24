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
using System.Xml.Linq;
namespace ProductCrude
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }
        private void ClearFileds()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();

        }
        private DataSet GetAllproduct()
        {
            string qry = "select * from product";
            da = new SqlDataAdapter(qry, con);
            // add PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // scb will track the DataSet & generate the qry --> assign to DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is the name given to the table which is in the DataSet
            // if not given then it will take default name is [0]
            //da.Fill(ds);
            da.Fill(ds, "pro");
            return ds;

        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllproduct();
                // create new row to add record
                DataRow row = ds.Tables["pro"].NewRow();
                row["PName"] = txtName.Text;
                row["Price"] = txtPrice.Text;

                //attach row to the pro table
                ds.Tables["pro"].Rows.Add(row);
                int result = da.Update(ds.Tables["pro"]);
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
                ds = GetAllproduct();
                DataRow row = ds.Tables["pro"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    // override the value from textbox to row
                    row["PName"] = txtName.Text;
                    row["Price"] = txtPrice.Text;

                    int result = da.Update(ds.Tables["pro"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                        ClearFileds();
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
                ds = GetAllproduct();
                DataRow row = ds.Tables["pro"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["pro"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFileds();
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
                ds = GetAllproduct();
                DataRow row = ds.Tables["pro"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    txtName.Text = row["PName"].ToString();
                    txtPrice.Text = row["Price"].ToString();

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

        private void btnshowallproducts_Click(object sender, EventArgs e)
        {
            ds = GetAllproduct();
            dataGridView1.DataSource = ds.Tables["pro"];

        }

        private void button5_Click(object sender, EventArgs e)
        {

            ds = GetAllproduct();
            dataGridView1.DataSource = ds.Tables["pro"];
        }
    }
}
