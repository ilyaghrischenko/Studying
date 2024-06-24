using Microsoft.EntityFrameworkCore;
using DataBase.Models;
using static System.Console;

namespace DataBase
{
    public static class PersonalManagementSystemInfo
    {
        public static void ShowAllDataBase()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    ShowAllEmployees();
                    ShowAllAddresses();
                    ShowAllBranches();
                    ShowAllBusinessTrips();
                    ShowAllDepartments();
                    ShowAllInsurances();
                    ShowAllPayments();
                    ShowAllTrainings();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllEmployees()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Employees:");
                    db.Instructors.Include("Department").ToList().ForEach(WriteLine);
                    db.Managers.Include("Department").Include("BusinessTrip").ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllAddresses()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Addresses:");
                    db.Addresses.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllBranches()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Branches:");
                    db.Branches.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllBusinessTrips()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Business trips:");
                    db.BusinessTrips.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllDepartments()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Departments:");
                    db.Departments.Include("Branch").Include("Address").ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllInstructors()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Instructors:");
                    db.Instructors.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllInsurances()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Insurances:");
                    db.Insurances.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllManagers()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Managers:");
                    db.Managers.ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllPayments()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Payments:");
                    db.Payments.Include("Employee").Include("Insurance").ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
        public static void ShowAllTrainings()
        {
            using (PersonalManagementSystemContext db = new())
            {
                try
                {
                    WriteLine("Trainings:");
                    db.Trainings.Include("Instructor").ToList().ForEach(WriteLine);
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}