using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{

    class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JobTitle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double BasicSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_title = job;
        }

        public string GetFirstName()
        { return this.first_name; }

        public void SetFirstName(string value)
        { this.first_name = value; }

        public string GetLastName()
        { return this.last_name; }
        public void SetLastName(string value)
        { this.last_name = value; }

        public string GetDepartment()
        { return this.department; }
        public void SetDepartment(string value)
        { this.department = value; }

        public string GetJobTitle()
        { return this.job_title; }
        public void SetJobTitle(string value)
        { this.job_title = value; }

        public double GetBasicSalary()
        { return this.basic_salary; }
        public void SetBasicSalary(double value)
        { this.basic_salary = value; }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            this.basic_salary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return this.basic_salary;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            throw new NotImplementedException();
        }
    }
}