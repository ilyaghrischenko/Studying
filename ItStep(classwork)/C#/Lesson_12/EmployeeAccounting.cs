using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_12
{
    public class EmployeeAccounting
    {
        public List<Employee> Employees { get; set; } = new();

        public EmployeeAccounting(List<Employee> employees)
        {
            Employees = employees;
        }

        public void Show()
        {
            WriteLine("Employees:");
            foreach (var item in Employees)
            {
                item.Show();
            }
        }
        public void Input()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employees[i].Input();
            }
        }

        public void AddEmployee(Employee employee)
        {
            bool isEqual = false;
            foreach (var item in Employees)
            {
                if (item.Equals(employee)) isEqual = true;
            }

            if (!isEqual) Employees.Add(employee);
        }
        public void RemoveEmployee(string pib)
        {
            bool isFind = false;
            bool isEqual = false;

            Employee finded = null;
            foreach (var item in Employees)
            {
                if (item.Pib == pib)
                {
                    isFind = true;
                    if (item.Equals(pib))
                    {
                        isEqual = true;
                        finded = item;
                    }
                }
            }
            if (isFind && !isEqual) Employees.Remove(finded); 
        }

        public void Search(string pib)
        {
            foreach (var item in Employees)
            {
                if (pib == item.Pib)
                {
                    WriteLine("Employee finded:");
                    item.Show();
                }
            }
        }
        public void Sort() => Employees.Sort();
    }
}
