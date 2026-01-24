using System.Data.SqlClient;

namespace CRUDUsingADO.Models
{
    public class StudentDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private readonly IConfiguration configuration;
        public StudentDAL(IConfiguration configuration)
        {
            this.configuration = configuration;
            string connstr = this.configuration.GetConnectionString("DefaultConnection");
            con = new SqlConnection(connstr);
        }
        //list
        public List<Student> GetStudents()
        {
            List<Student> slist = new List<Student>();
            string qry = "select * from student";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(dr["id"]);
                    student.Name = dr["name"].ToString();
                    student.Email = dr["email"].ToString();
                    student.Address = dr["address"].ToString();
                    student.Mobile_no = dr["mobile_no"].ToString();
                    slist.Add(student);
                }
            }
            con.Close();
            return slist;
        }

        //Add student
        public int AddStudent(Student stud)
        {
            int result = 0;
            string qry = "insert into student values(@name,@email,@address,@mobile_no)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", stud.Name);
            cmd.Parameters.AddWithValue("@email", stud.Email);
            cmd.Parameters.AddWithValue("@address", stud.Address);
            cmd.Parameters.AddWithValue("@mobile_no", stud.Mobile_no);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        //Edit Student
        public int EditStudent(Student stud)
        {
            int result = 0;
            string qry = "update student set name=@name,email=@email, address=@address, Mobile_no=@mobile_no where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", stud.Name);
            cmd.Parameters.AddWithValue("@email", stud.Email);
            cmd.Parameters.AddWithValue("@address", stud.Address);
            cmd.Parameters.AddWithValue("@mobile_no", stud.Mobile_no);
            cmd.Parameters.AddWithValue("@id", stud.Id);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        //select single emp
        public Student GetstudById(int id)
        {
            Student stud = new Student();
            string qry = "select * from student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    stud.Id = Convert.ToInt32(dr["id"]);
                    stud.Name = dr["name"].ToString();
                    stud.Email = dr["email"].ToString();

                    stud.Address = dr["address"].ToString();
                    stud.Mobile_no = dr["mobile_no"].ToString();
                }
            }
            con.Close();
            return stud;
        }
        // delete
        public int DeleteStud(int id)
        {
            int result = 0;
            string qry = "delete from student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}