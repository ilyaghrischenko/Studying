using Lesson_4;
using Lesson_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using static System.Console;

using (UniversityContext db = new())
{
    try
    {
        #region classwork
        //WriteLine("Students:");
        //db.Students
        //      .ToList()
        //      .ForEach(WriteLine);
        //WriteLine();
        //ReadKey();

        //WriteLine("Courses:");
        //db.Courses
        //      .Include("Teacher")
        //      .ToList()
        //      .ForEach(WriteLine);
        //WriteLine();
        //ReadKey();

        //WriteLine("Teachers:");
        //db.Teachers
        //      .Include("Department")
        //      .ToList()
        //      .ForEach(WriteLine);
        //WriteLine();
        //ReadKey();

        //WriteLine("Departments:");
        //db.Departments
        //      .Include("Address")
        //      .ToList()
        //      .ForEach(WriteLine);
        //WriteLine();
        //ReadKey();

        //WriteLine("Addresses:");
        //db.Addresses
        //      .ToList()
        //      .ForEach(WriteLine);
        //WriteLine();
        //ReadKey();
        #endregion

        ShowInfo(db);

        while (true)
        {
            Write("0 - Exit\n" +
                "1 - Add student\n" +
                "2 - Add teacher\n" +
                "3 - Add department\n" +
                "4 - Add course\n" +
                "5 - Add address\n" +
                "6 - Del student\n" +
                "7 - Del teacher\n" +
                "8 - Del department\n" +
                "9 - Del course\n" +
                "10 - Del address\n" +
                ": ");
            var choice = ReadLine();
            switch (choice)
            {
                case "0":
                    WriteLine("Goodbye!");
                    return;
                case "1":
                    Write("First name: ");
                    var firstName = ReadLine();
                    Write("Last name: ");
                    var lastName = ReadLine();

                    UniversityCRUD.AddStudent(firstName, lastName);
                    WriteLine("Student added");
                    break;
                case "2":
                    Write("First name: ");
                    var tFirstName = ReadLine();
                    Write("Last name: ");
                    var tLastName = ReadLine();
                    Write("Department id: ");
                    var departmentId = int.Parse(ReadLine());

                    if (db.Departments.SingleOrDefault(x => x.Id == departmentId) == null) throw new Exception("Invalid department id input");

                    UniversityCRUD.AddTeacher(tFirstName, tLastName, departmentId);
                    WriteLine("Teacher added");
                    break;
                case "3":
                    Write("Name: ");
                    var name = ReadLine();

                    UniversityCRUD.AddDepartment(name);
                    WriteLine("Department added");
                    break;
                case "4":
                    Write("Name: ");
                    var courseName = ReadLine();
                    Write("Teacher id: ");
                    var teacherId = int.Parse(ReadLine());

                    if (db.Teachers.SingleOrDefault(x => x.Id == teacherId) == null) throw new Exception("Invalid teacher id input");

                    UniversityCRUD.AddCourse(courseName, teacherId);
                    WriteLine("Course added");
                    break;
                case "5":
                    Write("City: ");
                    var city = ReadLine();
                    Write("Street: ");
                    var street = ReadLine();
                    Write("Building number: ");
                    var buildingNumber = uint.Parse(ReadLine());

                    UniversityCRUD.AddAddress(city, street, buildingNumber);
                    WriteLine("Address added");
                    break;
                case "6":
                    Write("Id: ");
                    var stId = int.Parse(ReadLine());
                    UniversityCRUD.DelStudent(stId);
                    WriteLine("Student deleted");
                    break;
                case "7":
                    Write("Id: ");
                    var tchId = int.Parse(ReadLine());
                    UniversityCRUD.DelTeacher(tchId);
                    WriteLine("Teacher deleted");
                    break;
                case "8":
                    Write("Id: ");
                    var dprId = int.Parse(ReadLine());
                    UniversityCRUD.DelDepartment(dprId);
                    WriteLine("Department deleted");
                    break;
                case "9":
                    Write("Id: ");
                    var crId = int.Parse(ReadLine());
                    UniversityCRUD.DelCourse(crId);
                    WriteLine("Course deleted");
                    break;
                case "10":
                    Write("Id: ");
                    var adId = int.Parse(ReadLine());
                    UniversityCRUD.DelAddress(adId);
                    WriteLine("Address deleted");
                    break;
            }
            WriteLine();
            ReadKey();
            Clear();
        }
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}

void ShowInfo(UniversityContext db)
{
    Write("Enter department name: ");
    var department = ReadLine() ?? throw new Exception("Invalid department name input");

    WriteLine("Teachers:");
    db.Teachers
         .Include("Department")
         .Where(x => x.Department.Name == department)
         .ToList()
         .ForEach(WriteLine);
    ReadKey();

    WriteLine("Courses:");
    db.Courses
         .Include("Teacher")
         .Where(x => x.Teacher.Department.Name == department)
         .ToList()
         .ForEach(WriteLine);
    ReadKey();

    //нема такого параметра, за яким я можу перевірити приналежність певного студента до певного факультету

    Write("Enter course name: ");
    var courseName = ReadLine() ?? throw new Exception("Invalid course name input");
    WriteLine($"Course: {db.Courses.SingleOrDefault(x => x.Name == courseName) ?? throw new Exception("Course with this name does not exist")}");

    Write("Enter student last name: ");
    var lastName = ReadLine() ?? throw new Exception("Invalid student last name input");
    WriteLine($"Student: {db.Students.SingleOrDefault(x => x.LastName == lastName) ?? throw new Exception("Student with this last name does not exist")}");

    Write("Enter teacher last name: ");
    var tLastName = ReadLine() ?? throw new Exception("Invalid teacher last name input");
    WriteLine($"Teacher: {db.Teachers.SingleOrDefault(x => x.LastName == tLastName) ?? throw new Exception("Teacher with this last name does not exist")}");

    Write("City: ");
    var city = ReadLine() ?? throw new Exception("Invalid city input");
    Write("Street: ");
    var street = ReadLine() ?? throw new Exception("Invalid street input");
    Write("Building number: ");
    if (!uint.TryParse(ReadLine(), out uint buildingNumber)) throw new Exception("Invalid building number input");

    WriteLine($"{db.Departments.SingleOrDefault(x => x.Address.City == city && x.Address.Street == street && x.Address.BuildingNumber == buildingNumber) ?? throw new Exception("Address with this data does not exist")}");
}