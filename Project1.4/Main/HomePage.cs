using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_OrderView_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuStartPage menustart = new MenuStartPage();
            menustart.ShowDialog();
            this.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            ChapeauLogic.EmployeeServices employeeServices = new ChapeauLogic.EmployeeServices();
            List<Employee> employeeInfo = employeeServices.GetEmployees(LoginPage.loginEmployeeID);
            foreach (Employee emp in employeeInfo)
            {
                employee.FirstName = emp.FirstName;
                employee.LastName = emp.LastName;
                employee.roleID = emp.roleID;
            };
            lbl_employeeName.Text = employee.FirstName + " " + employee.LastName ;
        }
        
    }
}
