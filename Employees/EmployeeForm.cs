using Employees.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Model.Farser;
using Employees.service;

namespace Employees
{
    public partial class EmployeeForm : Form
    {
        private void FillDetails(EmployeeModel dudu)
        {
            textBoxstreet.Text = dudu.Street;
            textBox_city.Text = dudu.City;
            textBox_phone.Text = dudu.Phone;
            textBox_selolar.Text = dudu.CellPhone;
            textBox_num.Text = dudu.Home_num;
            textBox_tz.Text = dudu.tz;
            textBox_first.Text = dudu.FirstName;
            textBox_last.Text = dudu.LastName;
            dateTimePicker1.Text = dudu.Bod.ToShortDateString();
        }

        private IEmploeeService emploeeService;
        

        public EmployeeForm()
        {
            InitializeComponent();
            emploeeService = new EmploeeService();
            EmploeeService.employees
        }


        public EmployeeModel[] Employees = {};



    }
}
