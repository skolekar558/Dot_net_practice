using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;   //Binary
using System.Xml; //XML
using System.Runtime.Serialization.Formatters.Soap; //SOAP
using System.Text.Json;
using System.Xml.Serialization;   //JSON
namespace ReadWriteForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {

                string path = @"D:\EmployeeData\employee.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File exits");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\EmployeeData";
                if (Directory.Exists(path)) // if folder is present then returns true
                {
                    MessageBox.Show("Directory exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory Created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\employee.dat", FileMode.Create,FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtId.Text));
                bw.Write(txtName.Text);
                bw.Write(Convert.ToDouble(txtSalary.Text)); 
                bw.Close();
                fs.Close();
                MessageBox.Show("Add the data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\employee.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtSalary.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
    }

        private void btnStreamWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\sample.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStreamRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeData\sample.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                emp = (Employee)bf.Deserialize(fs);
                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void XmlRead_Click_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                emp = (Employee)xs.Deserialize(fs);
                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                emp = (Employee)sf.Deserialize(fs);
                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToDouble(txtSalary.Text);
                FileStream fs = new FileStream(@"D:\EmployeeData\empJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"D:\EmployeeData\empJson.json", FileMode.Open, FileAccess.Read);
                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
