using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInterface;

namespace Employee_Application
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void computeSalaryBtn_Click(object sender, EventArgs e)
        {
            string FirstName = firstName.Text;
            string LastName = lastName.Text;
            string Department = department.Text;
            string JobTitle = jobTitle.Text;
            double RatePerHour = Convert.ToDouble(ratePerHour.Text);
            int TotalHoursWork = Convert.ToInt32(totalHoursWork.Text);

            EmployeeNamespace.PartTimeEmployee partTimeEmployee = new EmployeeNamespace.PartTimeEmployee(FirstName, LastName, Department, JobTitle);

            firstNameP.Text = partTimeEmployee.GetFirstName();
            lastNameP.Text = partTimeEmployee.GetLastName();
            partTimeEmployee.ComputeSalary(TotalHoursWork, RatePerHour);

            basicSalaryP.Text = partTimeEmployee.getSalary().ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void totalHoursWork_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

