using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

            public int AddStudent(Student student)
        {
            student.IsActive = 1;
            int result = 0;
            db.Students.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var model = db.Students.Where(stud => stud.Id == id).FirstOrDefault();
            if (model != null)
            {
                model.IsActive = 0;
                result = db.SaveChanges();
            }
            return result;

        }

        public int EditStudent(Student student)
        {
            int result = 0;
            var model = db.Students.Where(stud => stud.Id == student.Id).FirstOrDefault();
            if (model != null)
            {
                model.Name = student.Name;
                model.Email = student.Email;
                model.Address = student.Address;
                model.ContactNo = student.ContactNo;
                model.IsActive = 1;
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            return db.Students.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            var model = (from stud in db.Students
                         where stud.IsActive == 1
                         select stud).ToList();
            return model;
        }
    }
}
