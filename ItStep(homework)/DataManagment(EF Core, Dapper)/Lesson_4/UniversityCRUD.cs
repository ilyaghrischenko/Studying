using Lesson_4.Models;
using System.Net.Http.Headers;

namespace Lesson_4
{
    public static class UniversityCRUD
    {
        public static void AddStudent(string firstName, string lastName)
        {
            using (UniversityContext db = new())
            {
                Student student = new() { FirstName = firstName, LastName = lastName };
                if (db.Students.Contains(student)) return;
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
        public static void AddTeacher(string firstName, string lastName, int departmentId)
        {
            using (UniversityContext db = new())
            {
                Teacher teacher = new() { FirstName = firstName, LastName = lastName, DepartmentId = departmentId };
                if (db.Teachers.Contains(teacher)) return;
                if (db.Departments.SingleOrDefault(x => x.Id == departmentId) == null) throw new Exception("Invalid department id");
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }
        }
        public static void AddDepartment(string name, Address? address = null)
        {
            using (UniversityContext db = new())
            {
                Department department = new() { Name = name, Address = address };
                if (db.Departments.Contains(department)) return;
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }
        public static void AddCourse(string name, int teacherId)
        {
            using (UniversityContext db = new())
            {
                Course course = new() { Name = name, TeacherId = teacherId };
                if (db.Courses.Contains(course)) return;
                if (db.Teachers.SingleOrDefault(x => x.Id == teacherId) == null) throw new Exception("Invalid teacher id");
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }
        public static void AddAddress(string city, string street, uint buildingNumber)
        {
            using (UniversityContext db = new())
            {
                Address address = new() { City = city, Street = street, BuildingNumber = buildingNumber };
                if (db.Addresses.Contains(address)) return;
                db.Addresses.Add(address);
                db.SaveChanges();
            }
        }

        public static void DelStudent(int studentId)
        {
            using (UniversityContext db = new())
            {
                var student = db.Students.SingleOrDefault(x => x.Id == studentId) ?? throw new Exception("Invalid id");
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
        public static void DelTeacher(int teacherId)
        {
            using (UniversityContext db = new())
            {
                var teacher = db.Teachers.SingleOrDefault(x => x.Id == teacherId) ?? throw new Exception("Invalid id");
                db.Teachers.Remove(teacher);
                db.SaveChanges();
            }
        }
        public static void DelDepartment(int departmentId)
        {
            using (UniversityContext db = new())
            {
                var department = db.Departments.SingleOrDefault(x => x.Id == departmentId) ?? throw new Exception("Invalid id");
                db.Departments.Remove(department);
                db.SaveChanges();
            }
        }
        public static void DelCourse(int courseId)
        {
            using (UniversityContext db = new())
            {
                var course = db.Courses.SingleOrDefault(x => x.Id == courseId) ?? throw new Exception("Invalid id");
                db.Courses.Remove(course);
                db.SaveChanges();
            }
        }
        public static void DelAddress(int addressId)
        {
            using (UniversityContext db = new())
            {
                var address = db.Addresses.SingleOrDefault(x => x.Id == addressId) ?? throw new Exception("Invalid id");
                db.Addresses.Remove(address);
                db.SaveChanges();
            }
        }
    }
}
